using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DB_First.Model
{
    /// <summary>
    /// 客户端与服务器端交互时候使用的对象，数据库表太大，不使用
    /// </summary>
    public class ControllersInfo
    {

        /// <summary>
        /// 网络IP
        /// </summary>
        public string host_ip { get; set; }
        /// <summary>
        /// 网络端口号
        /// </summary>
        public string host_port { get; set; }
        /// <summary>
        /// 通信地址(控制器的通讯地址)
        /// </summary>
        public string addr { get; set; }

        /// <summary>
        /// 控制器在数据库中的ID
        /// </summary>
        public int regulator_id { get; set; }
    }
}
