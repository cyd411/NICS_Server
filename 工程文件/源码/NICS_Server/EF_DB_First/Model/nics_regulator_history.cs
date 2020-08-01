using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DB_First.Model
{
    /// <summary>
    /// nics_regulator_history:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class nics_regulator_history
    {
        
        public nics_regulator_history()
        { }
        #region Model
        private long _id;
        private long _nics_regulator_id;
        private long _client_id;
        private string _operate_type;
        private DateTime _operate_time;
        private string _is_operate;
        /// <summary>
        /// auto_increment
        /// </summary>
        public long id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// nics_regulator表控制器ID
        /// </summary>
        public long nics_regulator_id
        {
            set { _nics_regulator_id = value; }
            get { return _nics_regulator_id; }
        }
        /// <summary>
        /// nics_regulator表客户端ID
        /// </summary>
        public long client_id
        {
            set { _client_id = value; }
            get { return _client_id; }
        }
        /// <summary>
        /// nics_regulator表操作的类型，增加 更新 删除
        /// </summary>
        public string operate_type
        {
            set { _operate_type = value; }
            get { return _operate_type; }
        }
        /// <summary>
        /// nics_regulator表操作的时间
        /// </summary>
        public DateTime operate_time
        {
            set { _operate_time = value; }
            get { return _operate_time; }
        }
        /// <summary>
        /// 服务器软件是否进行过处理 0表示没有处理 1处理过
        /// </summary>
        public string is_operate
        {
            set { _is_operate = value; }
            get { return _is_operate; }
        }
        #endregion Model


    }
}
