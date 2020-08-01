using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DB_First.Model
{
    public class nics_regulator
    {
        /// <summary>
        /// 控制器的ID
        /// </summary>
        public int id { get; set; }
        public string create_name { get; set; }

        public string create_by { get; set; }

        public DateTime? create_date { get; set; }
        public string update_name { get; set; }

        public string update_by { get; set; }

        public DateTime? update_date { get; set; }

        public string sys_org_code { get; set; }

        public string sys_company_code { get; set; }

        public string name { get; set; }
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
        /// 控制器型号
        /// </summary>
        public string type { get; set; }


        public string serial_no { get; set; }
        public string cpua { get; set; }
        public string cpub { get; set; }
        public string cpuc { get; set; }
        /// <summary>
        /// 工作状态
        /// </summary>
        public string work_state { get; set; }
        public string remarks { get; set; }
        /// <summary>
        /// 客户端ID
        /// </summary>
        public int client_id { get; set; }
    }
}
