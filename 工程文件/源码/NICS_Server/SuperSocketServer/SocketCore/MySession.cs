using Common;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.SocketCore
{
    /// <summary>
    /// AppSession 代表一个和客户端的逻辑连接，
    /// 基于连接的操作应该定于在该类之中。你可以用该类的实例发送数据到客户端，
    /// 接收客户端发送的数据或者关闭连接。
    /// </summary>
    public class MySession : AppSession<MySession, MyRequestInfo>
    {
        /// <summary>
        /// 存客户端的id
        /// </summary>
        public string ClientID { get; set; }
        public MySession()
        {

        }
        protected override void OnSessionStarted()
        {
            //this.Send("Welcome to SuperSocket NICS Server");
        }

        protected override void OnInit()
        {
            base.OnInit();
        }

        protected override void HandleUnknownRequest(MyRequestInfo requestInfo)
        {
            this.Send("Unknow request");
        }

        protected override void HandleException(Exception e)
        {
            //这里先不要发送给客户端，直接在屏幕上显示出来
            //this.Send("Application error: {0}", e.Message);
            LogHelp.Info("Application error:" + e.Message);
        }

        protected override void OnSessionClosed(CloseReason reason)
        {
            //add you logics which will be executed after the session is closed

            base.OnSessionClosed(reason);
        }

        /// <summary>
        /// 发送函数
        /// </summary>
        /// <param name="strString"></param>
        public void MySend(string strString)
        {
            base.Send(strString);
        }
    }

}
