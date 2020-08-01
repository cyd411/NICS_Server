using BLL;
using Common;
using EF_DB_First.Model;
using Newtonsoft.Json;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocketServer.SocketCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.Command
{
    public class CMD : CommandBase<MySession, MyRequestInfo>
    {
        public override void ExecuteCommand(MySession session, MyRequestInfo requestInfo)
        {
            if (requestInfo.IsCorrectPkg)
            {
                if ((requestInfo.BodyKey == "LOGIN") ||(requestInfo.BodyKey == "LOGIN2"))
                {
                    string strClientID = requestInfo.ClientID;

                    if (requestInfo.BodyKey == "LOGIN2")
                    {
                        //根据验证码查询客户端ID，并返回给客户端
                        nics_clientBLL oNics_clientBLL = new nics_clientBLL();
                        strClientID = oNics_clientBLL.GetClientID(strClientID);                     
                    }

                    //根据站点号，查询相应的配置信息
                    nics_regulatorBLL oNics_regulatorBLL = new nics_regulatorBLL();
                    List<ControllersInfo> lst = oNics_regulatorBLL.GetModelsByClientID(strClientID);
                    string strJson = JsonConvert.SerializeObject(lst);
                    ControllerInfo oControllerInfo = new ControllerInfo(strClientID, strJson);

                    lock (NICSServerProgram.mMyServer)
                    {
                        var allSessions = NICSServerProgram.mMyServer.GetAllSessions();
                        int iCounter = allSessions.Count(p => p.ClientID == strClientID);
                        if (iCounter == 0)
                        {
                            session.ClientID = strClientID;
                            string strString = oControllerInfo.GetPkg();
                            session.Send(strString);
                        }
                        else
                        {
                            //关闭老连接
                            List<MySession> lstMySession = allSessions.Where(p => p.ClientID == strClientID).ToList();
                            foreach (var o in lstMySession)
                            {
                                if (o.SessionID != session.SessionID)
                                {
                                    LogHelp.Info("断开的客户端ID:" + o.ClientID + "       IP:" + o.RemoteEndPoint);
                                    o.Close();
                                }
                            }
                            //给新的发送注册信息
                            session.ClientID = strClientID;
                            string strString = oControllerInfo.GetPkg();
                            session.Send(strString);

                            LogHelp.Info("重复的客户端ID:" + strClientID + "       IP:" + session.RemoteEndPoint);
                        }

                    }
                }
                else if (requestInfo.BodyKey == "BYPASS")
                {
                    NICSServerProgram.TellAPIByRsp(requestInfo.OnePkg);

                }
                else
                {

                }
            }


            //session.Send(requestInfo.Parameters.Select(p => int.Parse(p)).Sum().ToString());
        }
    }
}
