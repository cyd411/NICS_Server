using Common;
using RestFulService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.Command
{
    public class CmdSingleCtrl : CmdBase
    {
        public CmdSingleCtrl(SingleCtrlInfo info)
        {
            KEY = "CMD";
            BODY_KEY = "BYPASS";
            CLINET_ID = info.client_id;

            List<byte> lst = new List<byte>();
            //控制器地址
            lst.Add(info.addr);
            //命令类型
            lst.Add(0x10); //写

            //参数1 端口对应的地址
            switch (info.device_port)
            {
                case 1:
                    lst.Add(0x40);
                    break;
                case 2:
                    lst.Add(0x41);
                    break;
                case 3:
                    lst.Add(0x42);
                    break;
                case 4:
                    lst.Add(0x43);
                    break;
                case 5:
                    lst.Add(0x44);
                    break;
                case 6:
                    lst.Add(0x45);
                    break;
                case 7:
                    lst.Add(0x46);
                    break;
                case 8:
                    lst.Add(0x47);
                    break;
                case 9:
                    lst.Add(0x48);
                    break;
                case 10:
                    lst.Add(0x49);
                    break;
                case 11:
                    lst.Add(0x4A);
                    break;
                case 12:
                    lst.Add(0x4B);
                    break;
                case 13:
                    lst.Add(0x4C);
                    break;
                case 14:
                    lst.Add(0x4D);
                    break;
                case 15:
                    lst.Add(0x4E);
                    break;
                case 16:
                    lst.Add(0x4F);
                    break;
                case 17:
                    lst.Add(0xB0);
                    break;
                case 18:
                    lst.Add(0xB1);
                    break;
                case 19:
                    lst.Add(0xB2);
                    break;
                case 20:
                    lst.Add(0xB3);
                    break;
                case 21:
                    lst.Add(0xB4);
                    break;
                case 22:
                    lst.Add(0xB5);
                    break;
                case 23:
                    lst.Add(0xB6);
                    break;
                case 24:
                    lst.Add(0xB7);
                    break;
                default:
                    lst.Add(0x40);
                    break;
            }
            //参数2	不关心，写0或者1都行，暂时固定写1
            lst.Add(1);
            //参数3	输出值（亮度）0~99
            lst.Add(info.analogue);
            //参数4 固定写0
            lst.Add(0);
            //参数5		标志
            //0：不执行远程下发的指令，将该位设置为0就是取消了远程控制（设备在重新启动后回取消远程控制，执行本地配置）
            //1：执行远程下发的指令 远程控制
            lst.Add(info.flag);         


            //参数6	0x00
            lst.Add(0x00);
            //参数7	0x00
            lst.Add(0x00);
            //参数8	0x00
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
