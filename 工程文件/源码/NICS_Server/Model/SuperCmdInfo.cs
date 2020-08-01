using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Model
{
    /// <summary>
    /// 单控使用的类
    /// </summary>
    [DataContract]
    public class SuperCmdInfo
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
        /// 命令类型
        /// </summary>
        [DataMember]
        public byte type { get; set; }




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
