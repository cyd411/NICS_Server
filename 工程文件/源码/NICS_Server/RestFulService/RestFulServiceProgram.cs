using Common;
using Model;
using RestFulService.Services;
using SuperSocketServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace RestFulService
{
    public class RestFulServiceProgram
    {
        private static Thread m_ClientSvrthread;
        public static ServerXml m_ServerXml = new ServerXml();
        public void ApiSvrStart()
        {
            //启动个线程
            m_ClientSvrthread = new Thread(new ParameterizedThreadStart(ApiSrvThread));
            //主线程退出，此线程立刻退出
            m_ClientSvrthread.IsBackground = true;
            m_ClientSvrthread.Start(m_ServerXml);




        }

        private static void SecondTask(ref int iLastSecond, DateTime oDateTime)
        {
            if (iLastSecond == oDateTime.Second)
                return;
            iLastSecond = oDateTime.Second;
            if (oDateTime.Second % 3 == 0)
            {
                NICSServerProgram.TellAPIByTimeout();
            }

        }

        /// <summary>
        ///客户端服务程序（连接云服务器）
        /// </summary>
        private static void ApiSrvThread(object ob)
        {
            ServerXml oServerXml = ob as ServerXml;
            int iLastSecond = -1;
            DateTime oNow;
            //string strApiUrl = "http://127.0.0.1:7788/";
            string strApiUrl = "http://127.0.0.1:" + oServerXml.API_Port + "/";
            RemoteCtrlInfoQueryServices service = new RemoteCtrlInfoQueryServices();
            WebServiceHost _serviceHost = new WebServiceHost(service, new Uri(strApiUrl));
            //或者第二种方法：WebServiceHost _serviceHost = new WebServiceHost(typeof(PersonInfoQueryServices), new Uri("http://127.0.0.1:7788/"));
            try
            {
                //如果这里报错，IDE必须以管理员方式运行
                _serviceHost.Open();
                //LogHelper.WriteLog(string.Format("Socket {0}:{1}启动失败，请检查权限或端口是否被占用！", config.Ip, config.Port));
                LogHelp.Info("API 服务启动成功" + strApiUrl);
                while (m_ClientSvrthread.IsAlive)
                {
                    oNow = DateTime.Now;
                    //秒任务
                    SecondTask(ref iLastSecond, oNow);
                    Thread.Sleep(100);
                }
                _serviceHost.Close();
            }
            catch (System.Exception ex)
            {
                //LogHelper.WriteLog(string.Format("Socket {0}:{1}启动失败，请检查权限或端口是否被占用！", config.Ip, config.Port));
                LogHelp.Info(ex.Message);
                LogHelp.Info("如果提示：HTTP 无法注册 " + strApiUrl + "，尝试以管理员运行程雪");
            }

        }
    }
}
