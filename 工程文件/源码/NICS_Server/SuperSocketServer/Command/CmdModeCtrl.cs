using Common;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperSocketServer.Command
{
    /// <summary>
    /// 模式控制
    /// </summary>
    public class CmdModeCtrl : CmdBase
    {

        public CmdModeCtrl(ModeCtrlInfo info)
        {
            KEY = "CMD";
            BODY_KEY = "BYPASS";
            CLINET_ID = info.client_id;

            List<byte> lst = new List<byte>();
            //控制器地址
            lst.Add(info.addr);
            //命令类型
            lst.Add(0x10); //写


            ////参数1 端口对应的地址
            switch (info.device_port)
            {
                case 1:
                    lst.Add(0x10);
                    break;
                case 2:
                    lst.Add(0x11);
                    break;
                case 3:
                    lst.Add(0x12);
                    break;
                case 4:
                    lst.Add(0x13);
                    break;
                case 5:
                    lst.Add(0x14);
                    break;
                case 6:
                    lst.Add(0x15);
                    break;
                case 7:
                    lst.Add(0x16);
                    break;
                case 8:
                    lst.Add(0x17);
                    break;
                case 9:
                    lst.Add(0x18);
                    break;
                case 10:
                    lst.Add(0x19);
                    break;
                case 11:
                    lst.Add(0x1A);
                    break;
                case 12:
                    lst.Add(0x1B);
                    break;
                case 13:
                    lst.Add(0x1C);
                    break;
                case 14:
                    lst.Add(0x1D);
                    break;
                case 15:
                    lst.Add(0x1E);
                    break;
                case 16:
                    lst.Add(0x1F);
                    break;
                case 17:
                    lst.Add(0x80);
                    break;
                case 18:
                    lst.Add(0x81);
                    break;
                case 19:
                    lst.Add(0x82);
                    break;
                case 20:
                    lst.Add(0x83);
                    break;
                case 21:
                    lst.Add(0x84);
                    break;
                case 22:
                    lst.Add(0x85);
                    break;
                case 23:
                    lst.Add(0x86);
                    break;
                case 24:
                    lst.Add(0x87);
                    break;
                default:
                    lst.Add(0x10);
                    break;
            }
            //参数2	模式：参见《模式对应表》中的编号
            lst.Add(info.mode);
            //参数3 关联端口1~8
            string strBindTmp = info.bind.Substring(0, 8);
            byte bBindTmp = Convert.ToByte(strBindTmp, 2);
            lst.Add(bBindTmp);

            //参数4 关联端口9~16
            strBindTmp = info.bind.Substring(8, 8);
            bBindTmp = Convert.ToByte(strBindTmp, 2);
            lst.Add(bBindTmp);
            //参数5 关联端口17~24
            strBindTmp = info.bind.Substring(16, 8);
            bBindTmp = Convert.ToByte(strBindTmp, 2);
            lst.Add(bBindTmp);
            //参数6	0x00
            lst.Add(info.paramA);
            //参数7	0x00
            lst.Add(info.paramB);
            //参数8	0x00
            lst.Add(info.paramC);


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
