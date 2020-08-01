using BLL;
using Common;
using EF_DB_First.Model;
using Model;
using SuperSocket.SocketBase;
using SuperSocketServer.SocketCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SuperSocketServer
{
    public class NICSServerProgram
    {
        public static MyServer mMyServer = new MyServer();
        /// <summary>
        /// 监听数据库线程ID
        /// </summary>
        private static Thread m_MonitorDBThreadID;
        /// <summary>
        /// 用来存储下发给客户端的命令，用于判断下发后命令是超时了，还是成功了
        /// </summary>
        public static Dictionary<string, DateTime> mBypssMap = new Dictionary<string, DateTime>();
        /// <summary>
        /// 向透明命令map中添加命令
        /// </summary>
        /// <param name="strCmd"></param>
        /// <param name="oDateTime"></param>
        public static void AddBypssMap(string strCmd, DateTime oDateTime)
        {
            lock (mBypssMap)
            {
                if (!mBypssMap.ContainsKey(strCmd))
                {
                    mBypssMap.Add(strCmd, oDateTime);
                }
            }
        }
        /// <summary>
        /// 通过接收到的透传命令返回值，通知其他的API
        /// </summary>
        /// <param name="strCmd">返回的命令</param>
        public static void TellAPIByRsp(string strCmd)
        {
            lock (mBypssMap)
            {
                if (mBypssMap.ContainsKey(strCmd))
                {
                    //通知其他api

                    //删除
                    mBypssMap.Remove(strCmd);
                }
            }
        }



        /// <summary>
        /// 通过接收到的透传命令返回值，通知其他的API
        /// </summary>
        /// <param name="strCmd">返回的命令</param>
        public static void TellAPIByTimeout()
        {
            lock (mBypssMap)
            {
                List<string> lst = new List<string>();

                foreach (KeyValuePair<string, DateTime> kvp in mBypssMap)
                {
                    if ((DateTime.Now - kvp.Value).Seconds >= 10)
                    {
                        //超时
                        //通知其他api

                        //添加删除对垒
                        lst.Add(kvp.Key);
                    }
                }
                //删除
                foreach (var o in lst)
                {
                    mBypssMap.Remove(o);
                }
            }
        }


        /// <summary>
        /// 监听数据库的线程
        /// </summary>
        private static void MonitorDBThread()
        {
            while (m_MonitorDBThreadID.IsAlive)
            {
                Thread.Sleep(1000);
                if (DateTime.Now.Minute % 5 == 0)
                {
                    //5分钟检查一次数据库
                    nics_regulator_historyBLL oNics_regulator_historyBLL = new nics_regulator_historyBLL();
                    List<nics_regulator_history> lst = oNics_regulator_historyBLL.GetWebNeedOperate();
                    foreach (var oNics_regulator_history in lst)
                    {
                        oNics_regulator_historyBLL.CenterSetWebCmd(oNics_regulator_history);

                        lock (NICSServerProgram.mMyServer)
                        {
                            var allSessions = NICSServerProgram.mMyServer.GetAllSessions();
                            int iCounter = allSessions.Count(p => p.ClientID == oNics_regulator_history.client_id.ToString());
                            if (iCounter == 0)
                            {
                                //什么都不需要做
                            }
                            else
                            {
                                //关闭老连接
                                List<MySession> lstMySession = allSessions.Where(p => p.ClientID == oNics_regulator_history.client_id.ToString()).ToList();
                                foreach (var oMySession in lstMySession)
                                {
                                    oMySession.Close();
                                    LogHelp.Info("控制器配置信息更新断开客户端ID:" + oMySession.ClientID + "       IP:" + oMySession.RemoteEndPoint);
                                }
                            }
                        }
                    }
                }
            }
        }



        /// <summary>
        /// 启动服务器端服务
        /// </summary>
        /// <param name="oServerXml">界面的xml参数</param>
        public void ServerSvrStart(ServerXml oServerXml)
        {
            var config = new SuperSocket.SocketBase.Config.ServerConfig()
            {
                Name = "SSServer",
                ServerTypeName = "SServer",
                ClearIdleSession = true, //60秒执行一次清理90秒没数据传送的连接
                ClearIdleSessionInterval = 60,
                IdleSessionTimeOut = 90,
                MaxRequestLength = 4096, //最大包长度
                Ip = "Any",
                Port = Convert.ToInt32(oServerXml.Port),
                MaxConnectionNumber = 100000,
            };
            //var app = new MyServer();
            //LogHelper.SetOnLog(new LogHelper.LogEvent((m) =>
            //{
            //    txtAll.Text = string.Join(" ", m, "\r\n");
            //    txtAll.Select(txtAll.TextLength, 0);
            //    txtAll.ScrollToCaret();
            //}));
            mMyServer.Setup(config);
            if (!mMyServer.Start())
            {
                //LogHelper.WriteLog(string.Format("Socket {0}:{1}启动失败，请检查权限或端口是否被占用！", config.Ip, config.Port));
                LogHelp.Info(string.Format("Socket {0}:{1}启动失败，请检查权限或端口是否被占用！", config.Ip, config.Port));
            }


            //启动个线程
            m_MonitorDBThreadID = new Thread(MonitorDBThread);
            //主线程退出，此线程立刻退出
            m_MonitorDBThreadID.IsBackground = true;
            m_MonitorDBThreadID.Start();

            LogHelp.Info("监听数据库线程启动完成！");
        }



    }
}
