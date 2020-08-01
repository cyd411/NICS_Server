using BLL;
using EF_DB_First.Model;
using Newtonsoft.Json;
using SuperSocket.SocketBase.Command;
using SuperSocketServer.SocketCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.Command
{
    public class DATA : CommandBase<MySession, MyRequestInfo>
    {
        public override void ExecuteCommand(MySession session, MyRequestInfo requestInfo)
        {
            if (requestInfo.IsCorrectPkg)
            {
                if (requestInfo.BodyKey == "MINUTEDATA")
                {
                    nics_regulator_output oNics_regulator_output = JsonConvert.DeserializeObject<nics_regulator_output>(requestInfo.Content);
                    nics_regulator_outputBLL oNics_regulator_outputBLL = new nics_regulator_outputBLL();
                    oNics_regulator_outputBLL.Add(oNics_regulator_output);
                }
                else if (requestInfo.BodyKey == "ALERTDATA")
                {
                    nics_alert oNics_alert = JsonConvert.DeserializeObject<nics_alert>(requestInfo.Content);
                    nics_alertBLL oNics_alertBLL = new nics_alertBLL();
                    oNics_alertBLL.Add(oNics_alert);

                }
                else
                {

                }
            }


            //session.Send(requestInfo.Parameters.Select(p => int.Parse(p)).Sum().ToString());
        }
    }
}
