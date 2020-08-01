using Common;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.SocketCore
{
    /// <summary>
    ///  IRequestInfo（请求信息，一次数据包）
    /// </summary>
    public class MyRequestInfo : IRequestInfo
    {
        public MyRequestInfo(byte[] header, byte[] bodyBuffer)
        {
            //Key = ((header[0] * 256) + header[1]).ToString();
            //Data = bodyBuffer;

            Key = System.Text.Encoding.UTF8.GetString(header, Macro.KEY_INDEX, Macro.KEY_LEN).TrimEnd(' ');
            Data = bodyBuffer;
            //var A = System.Text.Encoding.UTF8.GetString(header);
            //A = System.Text.Encoding.UTF8.GetString(bodyBuffer);

            List<byte> lstbAll = new List<byte>();
            lstbAll.AddRange(header);
            lstbAll.AddRange(bodyBuffer);
            AllPkg = lstbAll.ToArray();
            lstbAll.RemoveRange(lstbAll.Count - Macro.CHECK_LEN, Macro.CHECK_LEN);

            string strCrc = CRC.ToModbusCRC16(lstbAll.ToArray(), true);  //是否翻转

            if (strCrc == Checksum)
                IsCorrectPkg = true;
            else
                IsCorrectPkg = false;
        }
        /// <summary>
        /// 协议号对应自定义命令Name，会触摸自定义命令
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 正文字节码
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// 整个数据包
        /// </summary>
        private byte[] AllPkg { get; set; }

        /// <summary>
        /// 正文文本，大部分协议都不是这么玩的
        /// </summary>
        public string Body
        {
            get
            {
                //return Encoding.UTF8.GetString(Data);
                return Encoding.UTF8.GetString(Data);
            }
        }

        /// <summary>
        /// 包含的主体，不包括校验码
        /// </summary>
        public string BodyWithoutChechsum
        {
            get
            {
                //return Encoding.UTF8.GetString(Data);
                return Encoding.UTF8.GetString(Data, 0, Data.Length - Macro.CHECK_LEN);
            }
        }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content
        {
            get
            {
                string[] arr_strString = Body.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (arr_strString.Count() > 3)
                {
                    return arr_strString[2];
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// 站点号
        /// </summary>
        public string ClientID
        {
            get
            {
                return Body.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
            }
        }

        /// <summary>
        /// 主体中的关键字
        /// </summary>
        public string BodyKey
        {
            get
            {
                return Body.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0];
            }
        }

        /// <summary>
        /// 校验码
        /// </summary>
        public string Checksum
        {
            get
            {
                return System.Text.Encoding.UTF8.GetString(Data, Data.Length - Macro.CHECK_LEN, Macro.CHECK_LEN);
            }
        }
        /// <summary>
        /// 数据包有效
        /// </summary>
        public bool IsCorrectPkg { get; set; }
        /// <summary>
        /// 完整的包（明码）
        /// </summary>
        public string OnePkg
        {
            get
            {
                return System.Text.Encoding.UTF8.GetString(AllPkg);
            }
        }

    }
}
