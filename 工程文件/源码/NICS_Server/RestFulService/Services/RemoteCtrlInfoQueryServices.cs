using Model;
using RestFulService.Interfaces;
using RestFulService.Models;
using SuperSocketServer;
using SuperSocketServer.Command;
using SuperSocketServer.SocketCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace RestFulService.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RemoteCtrlInfoQueryServices : IRemoteCtrlInfoQuery
    {

        /// <summary>
        /// 发送单独控制
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public Result SendSingleCtrl(SingleCtrlInfo info)
        {
            Result oResult = new Result();
            if ((info.analogue > 99) || (info.analogue < 0))
            {
                oResult.message = "analogue参数错误";
                return oResult;
            }

            if ((info.device_port > 24) || (info.device_port < 1))
            {
                oResult.message = "device_port参数错误";
                return oResult;
            }


            try
            {
                CmdSingleCtrl oCmdSingleCtrl = new CmdSingleCtrl(info);
                string strCmd = oCmdSingleCtrl.GetPkg();
                lock (NICSServerProgram.mMyServer)
                {
                    var allSessions = NICSServerProgram.mMyServer.GetAllSessions();
                    int iCounter = allSessions.Count(p => p.ClientID == info.client_id);
                    if (iCounter == 1)
                    {
                        MySession oMySession = allSessions.First(p => p.ClientID == info.client_id);
                        oMySession.MySend(strCmd);
                        NICSServerProgram.AddBypssMap(strCmd, DateTime.Now);
                        oResult.message = "命令下发成功";
                    }
                    else
                    {
                        oResult.message = "离线";
                    }
                }

            }
            catch (System.Exception ex)
            {
                oResult.message = ex.Message;
            }

            return oResult;
        }


        /// <summary>
        /// 发送模式控制
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public Result SendModeCtrl(ModeCtrlInfo info)
        {
            Result oResult = new Result();
            if ((info.device_port > 24) || (info.device_port < 1))
            {
                oResult.message = "device_port参数错误";
                return oResult;
            }

            if (info.bind.Length != 24)
            {
                oResult.message = "bind参数错误";
                return oResult;
            }
            try
            {
                CmdModeCtrl oCmdModeCtrl = new CmdModeCtrl(info);
                string strCmd = oCmdModeCtrl.GetPkg();
                lock (NICSServerProgram.mMyServer)
                {
                    var allSessions = NICSServerProgram.mMyServer.GetAllSessions();
                    int iCounter = allSessions.Count(p => p.ClientID == info.client_id);
                    if (iCounter == 1)
                    {
                        MySession oMySession = allSessions.First(p => p.ClientID == info.client_id);
                        oMySession.MySend(strCmd);
                        NICSServerProgram.AddBypssMap(strCmd, DateTime.Now);
                        oResult.message = "命令下发成功";
                    }
                    else
                    {
                        oResult.message = "离线";
                    }
                }
            }
            catch (System.Exception ex)
            {
                oResult.message = ex.Message;
            }

            return oResult;
        }

        /// <summary>
        /// 高级参数下发
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public Result SendAdvancedPara(AdvancedParaInfo info)
        {
            Result oResult = new Result();
            byte[] arrbType = { 0x01, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E };
            if (arrbType.ToList().Contains(info.type))
            {
                //正确执行后面的代码
            }
            else
            {
                oResult.message = "type参数错误";
                return oResult;
            }



            try
            {
                CmdAdvancedPara oCmdAdvancedPara = new CmdAdvancedPara(info);
                string strCmd = oCmdAdvancedPara.GetPkg();
                lock (NICSServerProgram.mMyServer)
                {
                    var allSessions = NICSServerProgram.mMyServer.GetAllSessions();
                    int iCounter = allSessions.Count(p => p.ClientID == info.client_id);
                    if (iCounter == 1)
                    {
                        MySession oMySession = allSessions.First(p => p.ClientID == info.client_id);
                        oMySession.MySend(strCmd);
                        NICSServerProgram.AddBypssMap(strCmd, DateTime.Now);
                        oResult.message = "命令下发成功";
                    }
                    else
                    {
                        oResult.message = "离线";
                    }
                }

            }
            catch (System.Exception ex)
            {
                oResult.message = ex.Message;
            }

            return oResult;
        }

        /// <summary>
        /// 超级命令
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public Result SendSuperCmd(SuperCmdInfo info)
        {
            Result oResult = new Result();

            byte[] arrbType = { 0xFA, 0xFB, 0xFC };
            if (arrbType.ToList().Contains(info.type))
            {
                //正确执行后面的代码
            }
            else
            {
                oResult.message = "type参数错误";
                return oResult;
            }

            try
            {
                CmdSuperCmd oCmdSuperCmd = new CmdSuperCmd(info);
                string strCmd = oCmdSuperCmd.GetPkg();
                lock (NICSServerProgram.mMyServer)
                {
                    var allSessions = NICSServerProgram.mMyServer.GetAllSessions();
                    int iCounter = allSessions.Count(p => p.ClientID == info.client_id);
                    if (iCounter == 1)
                    {
                        MySession oMySession = allSessions.First(p => p.ClientID == info.client_id);
                        oMySession.MySend(strCmd);
                        NICSServerProgram.AddBypssMap(strCmd, DateTime.Now);
                        oResult.message = "命令下发成功";
                    }
                    else
                    {
                        oResult.message = "离线";
                    }
                }

            }
            catch (System.Exception ex)
            {
                oResult.message = ex.Message;
            }

            return oResult;
        }

    }
}
