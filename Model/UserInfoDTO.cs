using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	[Serializable]
	[DataContract]
	public class UserInfoDTO
	{
		/// <summary>
		/// 用户ID
		/// </summary>
		[DataMember]
		public decimal? USER_ID
		{
			get;
			set;
		}
		/// <summary>
		/// 公司ID
		/// </summary>
		[DataMember]
		public decimal? CUSTOMER_ID
		{
			get;
			set;
		}

		/// <summary>
		/// 公司名称
		/// </summary>
		[DataMember]
		public string CUSTOMER_NAME
		{
			get;
			set;
		}
		/// <summary>
		/// 用户名称
		/// </summary>
		[DataMember]
		public string USER_NAME
		{
			get;
			set;
		}
		/// <summary>
		/// 联系方式
		/// </summary>
		[DataMember]
		public string PHONE
		{
			get;
			set;
		}
		/// <summary>
		/// 关联类型
		/// </summary>
		[DataMember]
		public decimal RELEVANCE_TYPE
		{
			get;
			set;
		}
		/// <summary>
		/// 关联标识
		/// </summary>
		[DataMember]
		public decimal RELEVANCE_FLAG
		{
			get;
			set;
		}
	}

	public partial class UserDTO
	{
		/// <summary>
		/// 公司状态
		/// </summary>
		[DataMember]
		public decimal COMPANYSTATUS
		{
			get;
			set;
		}

		/// <summary>
		/// 公司有效时间
		/// </summary>
		[DataMember]
		public DateTime? VALIDITY
		{
			get;
			set;
		}

		/// <summary>
		/// 系统ID
		/// </summary>
		[DataMember]
		public string SYSTEM_ID
		{
			get;
			set;
		}

		/// <summary>
		/// 系统有效时间
		/// </summary>
		[DataMember]
		public DateTime? SYS_VALIDDATE
		{
			get;
			set;
		}

		/// <summary>
		/// 系统状态
		/// </summary>
		[DataMember]
		public decimal SYS_STATUS
		{
			get;
			set;
		}
        
        /// <summary>
        /// 系统简称
        /// </summary>
        public string SYSTEM_ABBR
        {
            get;
            set;
        }
	}
}
