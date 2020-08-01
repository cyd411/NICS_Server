using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DB_First.DAL
{
    public class nics_clientDAL
    {
        /// <summary>
        /// 根据客户端的验证码获取到客户端的id
        /// </summary>
        /// <param name="strAuthCode"></param>
        /// <returns></returns>
        public long GetClientID(string strAuthCode)
        {
            using (var db = new DatabaseContext())
            {

                var lst = db.nics_client.Where(p => p.auth_code.Equals(strAuthCode)).ToList();
                if (lst.Count > 0)
                {
                    return lst[0].id;
                }
                else
                {
                    return -1;
                }
            }
        }




    }
}
