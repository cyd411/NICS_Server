using EF_DB_First.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DB_First.DAL
{
    /// <summary>
    /// 数据访问类:nics_alert
    /// </summary>
    public class nics_alertDAL
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(nics_alert model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into nics_alert(");
            strSql.Append("regulator_id,alert_type,alert_info,alert_time)");
            strSql.Append(" values (");
            strSql.Append("@regulator_id,@alert_type,@alert_info,@alert_time)");
            MySqlParameter[] parameters = {
					new MySqlParameter("@regulator_id", MySqlDbType.Int32,11),
					new MySqlParameter("@alert_type", MySqlDbType.VarChar,32),
					new MySqlParameter("@alert_info", MySqlDbType.VarChar,255),
					new MySqlParameter("@alert_time", MySqlDbType.DateTime)};
            parameters[0].Value = model.regulator_id;
            parameters[1].Value = model.alert_type;
            parameters[2].Value = model.alert_info;
            parameters[3].Value = model.alert_time;

            int iRst = 0;
            using (var db = new DatabaseContext())
            {
                iRst = db.Database.ExecuteSqlCommand(strSql.ToString(), parameters);
            };
            return iRst;

        }
    }
}
