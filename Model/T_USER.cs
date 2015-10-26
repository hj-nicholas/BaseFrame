using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Model
{
    //用户表
    [Serializable]
    [DataContract]
    public partial class UserDTO
    {
        private decimal _user_id;
        /// <summary>
        /// 用户ID
        /// </summary>		
        [DataMember]
        public decimal USER_ID
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        private decimal? _customer_id;
        /// <summary>
        /// 客户ID
        /// </summary>		
        [DataMember]
        public decimal? CUSTOMER_ID
        {
            get { return _customer_id; }
            set { _customer_id = value; }
        }
        private string _login_id;
        /// <summary>
        /// 登录ID
        /// </summary>		
        [DataMember]
        public string LOGIN_ID
        {
            get { return _login_id; }
            set { _login_id = value; }
        }
        private string _user_name;
        /// <summary>
        /// 用户名
        /// </summary>		
        [DataMember]
        public string USER_NAME
        {
            get { return _user_name; }
            set { _user_name = value; }
        }
        private string _display_name;
        /// <summary>
        /// 用户显示名
        /// </summary>		
        [DataMember]
        public string DISPLAY_NAME
        {
            get { return _display_name; }
            set { _display_name = value; }
        }
        private string _password;
        /// <summary>
        /// 密码
        /// </summary>		
        [DataMember]
        public string PASSWORD
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _work_no;
        /// <summary>
        /// 工号
        /// </summary>		
        [DataMember]
        public string WORK_NO
        {
            get { return _work_no; }
            set { _work_no = value; }
        }
        private string _user_type;
        /// <summary>
        /// 用户类型
        /// </summary>		
        [DataMember]
        public string USER_TYPE
        {
            get { return _user_type; }
            set { _user_type = value; }
        }
        private string _status;
        /// <summary>
        /// 状态
        /// </summary>		
        [DataMember]
        public string STATUS
        {
            get { return _status; }
            set { _status = value; }
        }
        private string _sex;
        /// <summary>
        /// 性别
        /// </summary>		
        [DataMember]
        public string SEX
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private DateTime? _birthday;
        /// <summary>
        /// 生日
        /// </summary>		
        [DataMember]
        public DateTime? BIRTHDAY
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        private string _phone;
        /// <summary>
        /// 电话
        /// </summary>		
        [DataMember]
        public string PHONE
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _email;
        /// <summary>
        /// Email
        /// </summary>		
        [DataMember]
        public string EMAIL
        {
            get { return _email; }
            set { _email = value; }
        }
        private DateTime? _created_time;
        /// <summary>
        /// 创建时间
        /// </summary>		
        [DataMember]
        public DateTime? CREATED_TIME
        {
            get { return _created_time; }
            set { _created_time = value; }
        }
        private decimal? _created_by;
        /// <summary>
        /// 创建人
        /// </summary>		
        [DataMember]
        public decimal? CREATED_BY
        {
            get { return _created_by; }
            set { _created_by = value; }
        }
        private DateTime? _modified_time;
        /// <summary>
        /// 修改时间
        /// </summary>		
        [DataMember]
        public DateTime? MODIFIED_TIME
        {
            get { return _modified_time; }
            set { _modified_time = value; }
        }
        private decimal? _modified_by;
        /// <summary>
        /// 修改人
        /// </summary>		
        [DataMember]
        public decimal? MODIFIED_BY
        {
            get { return _modified_by; }
            set { _modified_by = value; }
        }
        private decimal? _login_err_num;
        /// <summary>
        /// 登录错误次数
        /// </summary>		
        [DataMember]
        public decimal? LOGIN_ERR_NUM
        {
            get { return _login_err_num; }
            set { _login_err_num = value; }
        }
        private DateTime? _login_time;
        /// <summary>
        /// 登录时间
        /// </summary>		
        [DataMember]
        public DateTime? LOGIN_TIME
        {
            get { return _login_time; }
            set { _login_time = value; }
        }
        private DateTime? _valid_date;
        /// <summary>
        /// 有效日期
        /// </summary>		
        [DataMember]
        public DateTime? VALID_DATE
        {
            get { return _valid_date; }
            set { _valid_date = value; }
        }
        private string _remark;
        /// <summary>
        /// 备注
        /// </summary>		
        [DataMember]
        public string REMARK
        {
            get { return _remark; }
            set { _remark = value; }
        }
        private string _u_key;
        /// <summary>
        /// U_Key
        /// </summary>		
        [DataMember]
        public string U_KEY
        {
            get { return _u_key; }
            set { _u_key = value; }
        }
        private string _temp_key;
        /// <summary>
        /// TEMP_KEY
        /// </summary>		
        [DataMember]
        public string TEMP_KEY
        {
            get { return _temp_key; }
            set { _temp_key = value; }
        }
        private decimal? _work_status;
        /// <summary>
        /// 工作状态
        /// </summary>		
        [DataMember]
        public decimal? WORK_STATUS
        {
            get { return _work_status; }
            set { _work_status = value; }
        }
        private decimal? _user_level;
        /// <summary>
        /// 人员级别
        /// </summary>		
        [DataMember]
        public decimal? USER_LEVEL
        {
            get { return _user_level; }
            set { _user_level = value; }
        }
        private decimal? _longitude;
        /// <summary>
        /// 经度
        /// </summary>		
        [DataMember]
        public decimal? LONGITUDE
        {
            get { return _longitude; }
            set { _longitude = value; }
        }
        private decimal? _latitude;
        /// <summary>
        /// 纬度
        /// </summary>		
        [DataMember]
        public decimal? LATITUDE
        {
            get { return _latitude; }
            set { _latitude = value; }
        }
        private decimal? _qq;
        /// <summary>
        /// QQ
        /// </summary>		
        [DataMember]
        public decimal? QQ
        {
            get { return _qq; }
            set { _qq = value; }
        }
        private string _fax;
        /// <summary>
        /// 传真
        /// </summary>		
        [DataMember]
        public string FAX
        {
            get { return _fax; }
            set { _fax = value; }
        }
        private string _head_picture;
        /// <summary>
        /// 头像
        /// </summary>		
        [DataMember]
        public string HEAD_PICTURE
        {
            get { return _head_picture; }
            set { _head_picture = value; }
        }
        private decimal? _is_public;
        /// <summary>
        /// 是否公开
        /// </summary>		
        [DataMember]
        public decimal? IS_PUBLIC
        {
            get { return _is_public; }
            set { _is_public = value; }
        }
        private string _salt;
        /// <summary>
        /// 加密GUID
        /// </summary>		
        [DataMember]
        public string SALT
        {
            get { return _salt; }
            set { _salt = value; }
        }
        private DateTime? _pass_modify_valid_date;
        /// <summary>
        /// 密码修改有效期
        /// </summary>		
        [DataMember]
        public DateTime? PASS_MODIFY_VALID_DATE
        {
            get { return _pass_modify_valid_date; }
            set { _pass_modify_valid_date = value; }
        }

    }

}