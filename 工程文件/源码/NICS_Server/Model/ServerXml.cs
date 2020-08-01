using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ServerXml
    {
        /// <summary>
        /// 界面端口
        /// </summary>
        private string _port;

        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }

        /// <summary>
        /// 界面上的ip
        /// </summary>
        private string _ip;

        public string Ip
        {
            get { return _ip; }
            set { _ip = value; }
        }
        /// <summary>
        /// 界面上的id
        /// </summary>
        private string _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 最大并发数
        /// </summary>
        private string _client_max_num;

        public string Client_max_num
        {
            get { return _client_max_num; }
            set { _client_max_num = value; }
        }
        /// <summary>
        /// 超时时间
        /// </summary>
        private string _socket_timeout_ms;

        public string Socket_timeout_ms
        {
            get { return _socket_timeout_ms; }
            set { _socket_timeout_ms = value; }
        }



        /// <summary>
        /// 下载路径
        /// </summary>
        private string _File_Directory;

        public string File_Directory
        {
            get { return _File_Directory; }
            set { _File_Directory = value; }
        }
        /// <summary>
        /// API端口
        /// </summary>
        private string _API_Port;

        public string API_Port
        {
            get { return _API_Port; }
            set { _API_Port = value; }
        }

       

    }
}
