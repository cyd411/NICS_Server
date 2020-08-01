using Common;
using SuperSocketServer.SocketCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.Command
{
    public class CmdBase
    {
        public string KEY { get; set; }
        private int BODY_LEN_OF_HEAD { get; set; }

        public string BODY_KEY { get; set; }
        public string CLINET_ID { get; set; }
        public string CONTENT { get; set; }
        /// <summary>
        /// 获取到body
        /// </summary>
        public string BodyWithoutChecksum
        {
            get
            {
                string strTmp = "";
                //拼接处body部分
                if (CONTENT == "")
                {
                    strTmp = string.Format(" {0} {1} ", BODY_KEY, CLINET_ID);
                }
                else
                {
                    strTmp = string.Format(" {0} {1} {2} ", BODY_KEY, CLINET_ID, CONTENT);
                }
                return strTmp;
            }
        }
        /// <summary>
        /// 获取包
        /// </summary>
        private string Pkg
        {
            get
            {
                if (KEY.Length > Macro.KEY_LEN)
                    return "";
                string strKeyFormat = "{0,-" + Macro.KEY_LEN + "}";
                string strKey = string.Format(strKeyFormat, KEY);

                string strBody = BodyWithoutChecksum;
                //body的长度
                BODY_LEN_OF_HEAD = strBody.Length + Macro.CHECK_LEN;

                string strBodyLenOfHeadFormat = "{0:D" + Macro.BODY_LEN_FROM_HEAD_LEN + "}";
                string strBodyLenOfHead = string.Format(strBodyLenOfHeadFormat, BODY_LEN_OF_HEAD);

                //拼接处body部分 
                string strTmp = string.Format("{0}{1}{2}", strKey, strBodyLenOfHead, strBody);


                byte[] arrbBuff = Encoding.UTF8.GetBytes(strTmp);
                string strCrc = CRC.ToModbusCRC16(arrbBuff, true);
                strTmp = strTmp + strCrc;

                return strTmp;
            }
        }


        public virtual string GetPkg()
        {
            return Pkg;
        }

    }
}
