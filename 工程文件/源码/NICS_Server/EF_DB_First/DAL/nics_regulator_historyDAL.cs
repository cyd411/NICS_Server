using EF_DB_First.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DB_First.DAL
{
    public class nics_regulator_historyDAL
    {
        /// <summary>
        /// 根据命令状态搜索相关的记录
        /// </summary>
        /// <param name="strIsOperate">服务器软件是否进行过处理 0表示没有处理 1处理过</param>
        /// <returns></returns>
        public List<nics_regulator_history> Select(string strIsOperate)
        {
            using (var db = new DatabaseContext())
            {
                var lst = (from a in db.nics_regulator_history
                           where a.is_operate == strIsOperate
                           select a).ToList();
                return lst;
            }
        }

        /// <summary>
        ///  根据站点号，命令的下发时间更新数据库的内容
        /// </summary>
        /// <param name="onics_regulator_history">控制命令对象</param>
        /// <returns></returns>
        public int Update(nics_regulator_history onics_regulator_history)
        {
            int iRst = 0;
            using (var db = new DatabaseContext())
            {
                bool bRst = db.nics_regulator_history.Any(p => (p.id == onics_regulator_history.id));
                if (bRst)
                {
                    //存在
                    var lst = (from a in db.nics_regulator_history
                               where a.id == onics_regulator_history.id
                               select a).ToList();
                    for (int i = 0; i < lst.Count; i++)
                    {
                        lst[i].is_operate = onics_regulator_history.is_operate;
                    }
                    iRst = db.SaveChanges();

                }
            }
            return iRst;
        }
    }
}
