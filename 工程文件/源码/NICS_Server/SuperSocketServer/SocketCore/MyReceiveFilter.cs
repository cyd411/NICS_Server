using SuperSocket.Facility.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.SocketCore
{
    //FixedHeaderReceiveFilter<IRequestInfo>（数据包的解析）
    public class MyReceiveFilter : FixedHeaderReceiveFilter<MyRequestInfo>//过滤器
    {
        //数据格式
        /// +-------+---+-------------------------------+
        /// | 请求名    | 4字符 |                       |
        /// | body长度  | 4字符 |                       |
        /// | 正文内容  | n字符 |        request body   |
        /// | 校验码    | 4字符 |                       |
        /// +-------+---+-------------------------------+
        public MyReceiveFilter()
            : base(Macro.KEY_LEN + Macro.BODY_LEN)
        {

        }
        /// <summary>
        /// 获取数据包中body的长度
        /// </summary>
        /// <param name="header"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        protected override int GetBodyLengthFromHeader(byte[] header, int offset, int length)
        {
            //return (int)header[offset + 2] * 256 + (int)header[offset + 3];//2字节，计算出数据长度
            string strBodyLength = System.Text.Encoding.UTF8.GetString(header, offset + Macro.BODY_INDEX, Macro.BODY_LEN);
            return Convert.ToInt32(strBodyLength);
        }

        /// <summary>
        /// 解析请求的数据
        /// </summary>
        /// <param name="header"></param>
        /// <param name="bodyBuffer"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        protected override MyRequestInfo ResolveRequestInfo(ArraySegment<byte> header, byte[] bodyBuffer, int offset, int length)
        {

            //byte[] body = bodyBuffer.Skip(offset).Take(length).ToArray(); 此方法执行效率太慢
            byte[] arrbBody = new byte[length];
            Array.Copy(bodyBuffer, offset, arrbBody, 0, length);
            return new MyRequestInfo(header.Array, arrbBody);
        }
    }
}
