using Common;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.Command
{
    /// <summary>
    /// 超级命令
    /// </summary>
    public class CmdSuperCmd : CmdBase
    {
        public CmdSuperCmd(SuperCmdInfo info)
        {
            KEY = "CMD";
            BODY_KEY = "BYPASS";
            CLINET_ID = info.client_id;

            List<byte> lst = new List<byte>();
            //控制器地址
            lst.Add(0xFA);
            //命令类型
            lst.Add(info.type);
            //参数1
            lst.Add(0);
            //参数2
            lst.Add(0);
            //参数3	
            lst.Add(0);
            //参数4 
            lst.Add(0);
            //参数5		
            lst.Add(0);
            //参数6	
            lst.Add(0x00);
            //参数7	
            lst.Add(0x00);
            //参数8	
            lst.Add(0x00);
            //计算校验(控制可以直接使用的)
            string strCrc = CRC.ToModbusCRC16(lst.ToArray(), true);  //是否翻转
            //16进制，转成16进制显示
            foreach (var m in lst)
            {
                CONTENT += Convert.ToString(m, 16).ToUpper().PadLeft(2, '0');
            }
            CONTENT = info.regulator_id + " " + info.host_ip + " " + info.host_port + " " + CONTENT + strCrc;

        }



    }
}
