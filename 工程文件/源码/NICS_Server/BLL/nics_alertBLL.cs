using EF_DB_First.DAL;
using EF_DB_First.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public enum StateType
    {
        /// <summary>
        /// 状态没有问题
        /// </summary>
        OK = 0,
        /// <summary>
        /// 控制器网络通讯异常（通讯模块有问题）
        /// </summary>
        SocketOffline = 1,

        /// <summary>
        /// 控制器命令交互异常（发命令没有返回）
        /// </summary>
        ControllerOffline = 2,
    }

    public class nics_alertBLL
    {

        private nics_alertDAL m_DAL = new nics_alertDAL();

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="oNics_alert"></param>
        /// <returns>返回更新的记录条数</returns>
        public int Add(nics_alert oNics_alert)
        {
            if (oNics_alert.alert_info == StateType.SocketOffline.ToString())
                oNics_alert.alert_info = "控制器网络通讯异常";
            else if (oNics_alert.alert_info == StateType.ControllerOffline.ToString())
                oNics_alert.alert_info = "控制器命令交互异常";
            else
            {

            }
            return m_DAL.Add(oNics_alert);
        }

    }
}
