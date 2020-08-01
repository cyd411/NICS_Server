using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.SocketCore
{
    public class Macro
    {
        /// <summary>
        /// 协议中key的长度
        /// </summary>
        public static int KEY_LEN = 4;

        /// <summary>
        /// 协议中key开始下标
        /// </summary>
        public static int KEY_INDEX = 0;

        /// <summary>
        /// 协议中body长度
        /// </summary>
        public static int BODY_LEN = 4;

        /// <summary>
        /// 协议中body开始下标
        /// </summary>
        public static int BODY_INDEX = KEY_INDEX + KEY_LEN;


        /// <summary>
        /// 协议中校验码长度
        /// </summary>
        public static int CHECK_LEN = 4;

        /// <summary>
        /// 协议中body长度
        /// </summary>
        public static int BODY_LEN_FROM_HEAD_LEN = 4;
    }
}
