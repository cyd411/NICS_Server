using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace RestFulService.Models
{
    /// <summary>
    /// 单控使用的类
    /// </summary>
    [DataContract]
    public class SingleCtrlInfo
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
        /// 输出值（亮度）：0~99
        /// </summary>
        [DataMember]
        public byte analogue { get; set; }


        /// <summary>
        /// 标志
        ///0：不执行远程下发的指令，将该位设置为0就是取消了远程控制（设备在重新启动后回取消远程控制，执行本地配置）
        ///1：执行远程下发的指令（远程控制）
        /// </summary>
        [DataMember]
        public byte flag { get; set; }

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
