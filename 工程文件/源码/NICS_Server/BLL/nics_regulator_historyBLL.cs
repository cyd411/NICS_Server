using EF_DB_First.DAL;
using EF_DB_First.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
   public class nics_regulator_historyBLL
    {
       private nics_regulator_historyDAL m_nics_regulator_historyDAL = new nics_regulator_historyDAL();
        /// <summary>
        /// web修改了控制器配置的信息表，中心需要下发的配置信息
        /// </summary>
        private string WEB_NEED_OPERATE_CMD = "0";


        /// <summary>
        /// 中心回应处理完
        /// </summary>
        private string CENTER_OPERATED_CMD = "1";

        /// <summary>
        /// 获取web修改了控制器配置的信息表，中心需要下发的配置信息
        /// </summary>
        /// <returns></returns>
        public List<nics_regulator_history> GetWebNeedOperate()
        {
            List<nics_regulator_history> lst = m_nics_regulator_historyDAL.Select(WEB_NEED_OPERATE_CMD);
            return lst;
        }       

        /// <summary>
        /// 设置中心处理完的配置信息
        /// </summary>
        /// <param name="onics_regulator_history">对象</param>
        /// <returns></returns>
        public int CenterSetWebCmd(nics_regulator_history onics_regulator_history)
        {
            onics_regulator_history.is_operate = CENTER_OPERATED_CMD;
            return m_nics_regulator_historyDAL.Update(onics_regulator_history);
        }
       
    }
}
