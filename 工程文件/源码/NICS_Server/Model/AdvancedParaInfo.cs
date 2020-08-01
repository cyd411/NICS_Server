using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Model
{
    /// <summary>
    /// 高级参数下发
    /// </summary>
    [DataContract]
    public class AdvancedParaInfo
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
        /// 命令类型
        /// </summary>
        [DataMember]
        public byte type { get; set; }



        /// <summary>
        /// 参数A
        /// </summary>
        [DataMember]
        public byte paramA { get; set; }

        /// <summary>
        /// 参数B
        /// </summary>
        [DataMember]
        public byte paramB { get; set; }
        /// <summary>
        /// 参数C
        /// </summary>
        [DataMember]
        public byte paramC { get; set; }
        /// <summary>
        /// 参数D
        /// </summary>
        [DataMember]
        public byte paramD { get; set; }
        /// <summary>
        /// 参数E
        /// </summary>
        [DataMember]
        public byte paramE { get; set; }
        /// <summary>
        /// 参数F
        /// </summary>
        [DataMember]
        public byte paramF { get; set; }
        /// <summary>
        /// 参数G
        /// </summary>
        [DataMember]
        public byte paramG { get; set; }
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
