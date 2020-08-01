using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RestFulService.Models
{
    public class Result
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        [DataMember]
        public string code { get; set; }
        /// <summary>
        /// 返回消息提示
        /// </summary>
        [DataMember]
        public string message { get; set; }



    }
}
