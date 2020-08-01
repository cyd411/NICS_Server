using Common;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.SocketCore
{


    /// <summary>
    /// AppServer 代表了监听客户端连接，承载TCP连接的服务器实例
    /// 。理想情况下，我们可以通过AppServer实例获取任何你想要的客户端连接，
    /// 服务器级别的操作和逻辑应该定义在此类之中。
    /// </summary>
    public class MyServer : AppServer<MySession, MyRequestInfo> // AppServer<TAppSession, TRequestInfo>（监听服务）
    {

        /// <summary>
        /// 使用本类中的事件
        /// </summary>
        public MyServer()
            : base(new DefaultReceiveFilterFactory<MyReceiveFilter, MyRequestInfo>())
        {
            this.NewSessionConnected += MyServer_NewSessionConnected;
            this.SessionClosed += MyServer_SessionClosed;
            //this.NewRequestReceived += MyServer_NewRequestReceived; //使用命令类，则不需要这里的事件
        }
        /// <summary>
        /// 外接提供事件
        /// </summary>
        public MyServer(SessionHandler<MySession> NewSessionConnected, SessionHandler<MySession, CloseReason> SessionClosed)
            : base(new DefaultReceiveFilterFactory<MyReceiveFilter, MyRequestInfo>())
        {
            this.NewSessionConnected += NewSessionConnected;
            this.SessionClosed += SessionClosed;
        }

        protected override void OnStarted()
        {
            //启动成功
            //LogHelper.WriteLog(string.Format("Socket启动成功：{0}:{1}", this.Config.Ip, this.Config.Port));
            LogHelp.Info(string.Format("Socket启动成功：{0}:{1}", this.Config.Ip, this.Config.Port));
        }

        void MyServer_NewSessionConnected(MySession session)
        {
            //连接成功
            LogHelp.Info(string.Format("Socket {0}连接成功！", session.RemoteEndPoint));


        }

        void MyServer_SessionClosed(MySession session, CloseReason value)
        {
            LogHelp.Info(string.Format("Socket {0}断开连接！原因：{1}", session.RemoteEndPoint, value.ToString()));
        }

        void MyServer_NewRequestReceived(MySession session, MyRequestInfo requestInfo)
        {
            //接受数据的处理，如果使用命令类，则不会进入到这里
            int a = 0;
            a++;
        }



    }
}
