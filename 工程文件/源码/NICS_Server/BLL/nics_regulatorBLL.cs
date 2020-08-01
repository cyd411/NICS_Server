using EF_DB_First.DAL;
using EF_DB_First.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class nics_regulatorBLL
    {
        private nics_regulatorDAL m_nics_regulatorDAL = new nics_regulatorDAL();

        /// <summary>
        /// 根据客户端ID获取，此ID下关联的控制器相关信息
        /// </summary>
        /// <param name="strClientID"></param>
        /// <returns>获取失败返回 元素个数为0的list</returns>
        public List<ControllersInfo> GetModelsByClientID(string strClientID)
        {
            List<nics_regulator> lstNics_regulator = new List<nics_regulator>();
            List<ControllersInfo> lstRst = new List<ControllersInfo>();
            int iClientID = 0;
            bool bRst = int.TryParse(strClientID, out iClientID);
            if (bRst)
            {
                lstNics_regulator = m_nics_regulatorDAL.GetModelsByClientID(iClientID);
                foreach (var o in lstNics_regulator)
                {
                    ControllersInfo oControllersInfo = new ControllersInfo();
                    oControllersInfo.host_ip = o.host_ip;
                    oControllersInfo.host_port = o.host_port;
                    oControllersInfo.addr = o.addr;
                    oControllersInfo.regulator_id = o.id;
                    lstRst.Add(oControllersInfo);
                }
            }
            return lstRst;



        }
    }
}
