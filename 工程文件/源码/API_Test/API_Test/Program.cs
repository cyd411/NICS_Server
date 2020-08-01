using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace API_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //框架代码至少在4.6


            Console.Title = "Restful客户端第三方RestSharpDemo测试";
            //方法二、使用第三方RestSharp
            var client = new RestSharp.RestClient("http://127.0.0.1:7788");
            var requestGet = new RestRequest("PersonInfoQuery/{name}", Method.GET);
            requestGet.AddUrlSegment("name", "王二麻子");
            IRestResponse response = client.Execute(requestGet);
            var contentGet = response.Content;
            Console.WriteLine("GET方式获取结果：" + contentGet);



            var requestPost1 = new RestRequest("api/v1/RemoteCtrlInfoQuery/Single/Info", Method.PUT);
            SingleCtrlInfo info = new SingleCtrlInfo();

            info.host_ip = "192.168.1.127";
            info.host_port = "23";
            info.addr = 0;
            
            info.device_port = 1;
          
            info.analogue = 0;
            info.flag = 1;
            info.regulator_id = 2;
            info.client_id = "1";

            var json = JsonConvert.SerializeObject(info);
            requestPost1.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse responsePost = client.Execute(requestPost1);
            var contentPost = responsePost.Content;
            Console.WriteLine("PUT方式获取结果：" + contentPost);


            var requestPost2 = new RestRequest("api/v1/RemoteCtrlInfoQuery/Mode/Info", Method.PUT);
            ModeCtrlInfo info2 = new ModeCtrlInfo();

            info2.host_ip = "192.168.1.127";
            info2.host_port = "23";
            info2.addr = 0;
            info2.bind = "100000000000000000000001";
            info2.device_port = 1;
            info2.mode = 1;
            info2.paramA = 0;
            info2.paramB = 0;
            info2.paramC = 0;
            info2.regulator_id = 2;
            info2.client_id = "1";

            var json2 = JsonConvert.SerializeObject(info2);
            requestPost2.AddParameter("application/json", json2, ParameterType.RequestBody);
            IRestResponse responsePost2 = client.Execute(requestPost2);
            var contentPost2 = responsePost.Content;
            Console.WriteLine("PUT方式获取结果：" + contentPost);


            Console.Read();

        }
    }


    [Serializable]
    public class ModeCtrlInfo
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
     
        public byte addr { get; set; }



        /// <summary>
        /// 1~24口
        /// </summary>
        
        public byte device_port { get; set; }

        /// <summary>
        /// 模式对应表
        /// </summary>
        
        public byte mode { get; set; }


        /// <summary>
        /// 绑定端口 需要写入24口的状态（1：绑定 0：无效）长度24
        /// </summary>
       
        public string bind { get; set; }


        /// <summary>
        /// 参数A 没有则填写0
        /// </summary>
       
        public byte paramA { get; set; }


        /// <summary>
        /// 参数B 没有则填写0
        /// </summary>
        
        public byte paramB { get; set; }

        /// <summary>
        /// 参数C 没有则填写0
        /// </summary>
        
        public byte paramC { get; set; }


        /// <summary>
        /// 客户端软件ID
        /// </summary>
       
        public string client_id { get; set; }

        /// <summary>
        /// 控制器在数据库中的ID
        /// </summary>
       
        public int regulator_id { get; set; }

    }
    [Serializable]
    public class SingleCtrlInfo
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

        public byte addr { get; set; }


        /// <summary>
        /// 1~24口
        /// </summary>

        public byte device_port { get; set; }



        /// <summary>
        /// 输出值（亮度）：0~99
        /// </summary>

        public byte analogue { get; set; }


        /// <summary>
        /// 标志
        ///0：不执行远程下发的指令，将该位设置为0就是取消了远程控制（设备在重新启动后回取消远程控制，执行本地配置）
        ///1：执行远程下发的指令（远程控制）
        /// </summary>

        public byte flag { get; set; }

        /// <summary>
        /// 客户端软件ID
        /// </summary>

        public string client_id { get; set; }

        /// <summary>
        /// 控制器在数据库中的ID
        /// </summary>

        public int regulator_id { get; set; }
    }
}
