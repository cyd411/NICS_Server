using EF_DB_First.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class nics_clientBLL
    {
        private nics_clientDAL m_DAL = new nics_clientDAL();
        /// <summary>
        /// 获取客户端的ID
        /// </summary>
        /// <param name="strAuthCode">验证码</param>
        /// <returns>返回客户端ID</returns>
        public string GetClientID(string strAuthCode)
        {
            long lClientID = m_DAL.GetClientID(strAuthCode);
            return lClientID.ToString();
        }
    }
}
