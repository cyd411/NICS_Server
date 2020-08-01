using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.Command
{
    class ControllerInfo : CmdBase
    {
        public ControllerInfo(string strClientId, string strContent)
        {
            KEY = "CMD";
            BODY_KEY = "CONTROLLER_INFO";
            CLINET_ID = strClientId;
            CONTENT = strContent;
        }
    }
}
