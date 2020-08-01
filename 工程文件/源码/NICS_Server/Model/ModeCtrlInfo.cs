using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Model
{
    public class ModeCtrlInfo
    {
        /// <summary>
        /// 网络IP
        /// </summary>
        [DataMember]
        public string host_ip { get; set; }


        /// <summary>
        /// 网络端口号
        /// </summary>
        [DataMember]
        public string host_port { get; set; }


        /// <summary>
        /// 通信地址(控制器的通讯地址)
        /// </summary>
        [DataMember]
        public byte addr { get; set; }



        /// <summary>
        /// 1~24口
        /// </summary>
        [DataMember]
        public byte device_port { get; set; }

        /// <summary>
        /// 模式对应表
        /// </summary>
        [DataMember]
        public byte mode { get; set; }


        /// <summary>
        /// 绑定端口 需要写入24口的状态（1：绑定 0：无效）长度24
        /// </summary>
        [DataMember]
        public string bind { get; set; }


        /// <summary>
        /// 参数A 没有则填写0
        /// </summary>
        [DataMember]
        public byte paramA { get; set; }


        /// <summary>
        /// 参数B 没有则填写0
        /// </summary>
        [DataMember]
        public byte paramB { get; set; }

        /// <summary>
        /// 参数C 没有则填写0
        /// </summary>
        [DataMember]
        public byte paramC { get; set; }


        /// <summary>
        /// 客户端软件ID
        /// </summary>
        [DataMember]
        public string client_id { get; set; }

        /// <summary>
        /// 控制器在数据库中的ID
        /// </summary>
        [DataMember]
        public int regulator_id { get; set; }

    }
}
