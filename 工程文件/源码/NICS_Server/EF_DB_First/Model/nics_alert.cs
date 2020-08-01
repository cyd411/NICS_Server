using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DB_First.Model
{
    /// <summary>
    /// 状态信息表，可以理解为报警表
    /// </summary>
    [Serializable]
    public partial class nics_alert
    {
        public nics_alert()
        { }
        #region Model
        private long _id;
        private int? _regulator_id;
        private string _alert_type;
        private string _alert_info;
        private DateTime? _alert_time;
        /// <summary>
        /// auto_increment
        /// </summary>
        public long id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 控制器ID(数据库中的ID)
        /// </summary>
        public int? regulator_id
        {
            set { _regulator_id = value; }
            get { return _regulator_id; }
        }
        /// <summary>
        /// 预警类型(数字)
        /// </summary>
        public string alert_type
        {
            set { _alert_type = value; }
            get { return _alert_type; }
        }
        /// <summary>
        /// 报警信息（直接文字描述）
        /// </summary>
        public string alert_info
        {
            set { _alert_info = value; }
            get { return _alert_info; }
        }
        /// <summary>
        /// 预警时间
        /// </summary>
        public DateTime? alert_time
        {
            set { _alert_time = value; }
            get { return _alert_time; }
        }
        #endregion Model

    }
}
