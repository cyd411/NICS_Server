using EF_DB_First.DAL;
using EF_DB_First.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class nics_regulator_outputBLL
    {
        private nics_regulator_outputDAL m_nics_regulator_outputDAL = new nics_regulator_outputDAL();

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="oNics_regulator_output"></param>
        /// <returns>返回更新的记录条数</returns>
        public int Add(nics_regulator_output oNics_regulator_output)
        {
            //oNics_regulator_output.watt = (Convert.ToDouble(oNics_regulator_output.watt) * 1.54).ToString() ;
            return m_nics_regulator_outputDAL.Add(oNics_regulator_output);
        }

    }
}
