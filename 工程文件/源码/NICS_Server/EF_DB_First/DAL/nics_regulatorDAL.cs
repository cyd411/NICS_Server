using EF_DB_First.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DB_First.DAL
{
    public class nics_regulatorDAL
    {
        /// <summary>
        /// 根据客户端的ID获取改ID下关联的所有控制器信息
        /// </summary>
        /// <param name="iClientID"></param>
        /// <returns></returns>
        public List<nics_regulator> GetModelsByClientID(int iClientID)
        {
            using (var db = new DatabaseContext())
            {
                var lst = db.nics_regulator.Where(p => p.client_id == iClientID).ToList();
                return lst;
            }

        }
    }
}
