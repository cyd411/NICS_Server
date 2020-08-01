using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF_DB_First.Model
{
    public class nics_client
    {

        /// <summary>
        /// auto_increment
        /// </summary>		
        private long _id;
        public long id
        {
            get { return _id; }
            set { _id = value; }
        }
        /// <summary>
        /// 创建人名称
        /// </summary>		
        private string _create_name;
        public string create_name
        {
            get { return _create_name; }
            set { _create_name = value; }
        }
        /// <summary>
        /// 创建人登录名称
        /// </summary>		
        private string _create_by;
        public string create_by
        {
            get { return _create_by; }
            set { _create_by = value; }
        }
        /// <summary>
        /// 创建日期
        /// </summary>		
        private DateTime? _create_date;
        public DateTime? create_date
        {
            get { return _create_date; }
            set { _create_date = value; }
        }
        /// <summary>
        /// 更新人名称
        /// </summary>		
        private string _update_name;
        public string update_name
        {
            get { return _update_name; }
            set { _update_name = value; }
        }
        /// <summary>
        /// 更新人登录名称
        /// </summary>		
        private string _update_by;
        public string update_by
        {
            get { return _update_by; }
            set { _update_by = value; }
        }
        /// <summary>
        /// 更新日期
        /// </summary>		
        private DateTime? _update_date;
        public DateTime? update_date
        {
            get { return _update_date; }
            set { _update_date = value; }
        }
        /// <summary>
        /// 所属部门
        /// </summary>		
        private string _sys_org_code;
        public string sys_org_code
        {
            get { return _sys_org_code; }
            set { _sys_org_code = value; }
        }
        /// <summary>
        /// 所属公司
        /// </summary>		
        private string _sys_company_code;
        public string sys_company_code
        {
            get { return _sys_company_code; }
            set { _sys_company_code = value; }
        }
        /// <summary>
        /// 所属区域
        /// </summary>		
        private long _area_id;
        public long area_id
        {
            get { return _area_id; }
            set { _area_id = value; }
        }
        /// <summary>
        /// 机构名称
        /// </summary>		
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// 地址
        /// </summary>		
        private string _address;
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }
        /// <summary>
        /// 电话
        /// </summary>		
        private string _tel;
        public string tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        /// <summary>
        /// 联系人
        /// </summary>		
        private string _contact;
        public string contact
        {
            get { return _contact; }
            set { _contact = value; }
        }
        /// <summary>
        /// 授权code（客户端登录时使用）
        /// </summary>		
        private string _auth_code;
        public string auth_code
        {
            get { return _auth_code; }
            set { _auth_code = value; }
        }
    }
}
