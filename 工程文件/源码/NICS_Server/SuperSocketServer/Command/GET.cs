using SuperSocket.SocketBase.Command;
using SuperSocketServer.SocketCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.Command
{
    public class GET : CommandBase<MySession, MyRequestInfo>
    {
        public override void ExecuteCommand(MySession session, MyRequestInfo requestInfo)
        {
            session.Send(requestInfo.Body);
            //session.Send(requestInfo.Parameters.Select(p => int.Parse(p)).Sum().ToString());
        }
    }
}
