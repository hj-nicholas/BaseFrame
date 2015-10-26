using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Model
{
	//REDAS数据库字段表
	[Serializable]
	[DataContract]
	public class RedasDbFieldDTO
	{
      	private decimal _fsq_field_id;
		/// <summary>
		/// 字段ID
        /// </summary>		
		[DataMember]
        public decimal FSQ_FIELD_ID
        {
            get{ return _fsq_field_id; }
            set{ _fsq_field_id = value; }
        }
		private decimal? _db_table_id;
		/// <summary>
		/// 表ID
        /// </summary>		
		[DataMember]
        public decimal? DB_TABLE_ID
        {
            get{ return _db_table_id; }
            set{ _db_table_id = value; }
        }
		private string _fsq_field;
		/// <summary>
		/// 字段
        /// </summary>		
		[DataMember]
        public string FSQ_FIELD
        {
            get{ return _fsq_field; }
            set{ _fsq_field = value; }
        }
		private string _fsq_field_chs;
		/// <summary>
		/// 字段中文说明
        /// </summary>		
		[DataMember]
        public string FSQ_FIELD_CHS
        {
            get{ return _fsq_field_chs; }
            set{ _fsq_field_chs = value; }
        }
		private string _field_type;
		/// <summary>
		/// 字段类型
        /// </summary>		
		[DataMember]
        public string FIELD_TYPE
        {
            get{ return _field_type; }
            set{ _field_type = value; }
        }
		private decimal? _field_length;
		/// <summary>
		/// 字段长度
        /// </summary>		
		[DataMember]
        public decimal? FIELD_LENGTH
        {
            get{ return _field_length; }
            set{ _field_length = value; }
        }
		private decimal? _field_precision;
		/// <summary>
		/// 精度
        /// </summary>		
		[DataMember]
        public decimal? FIELD_PRECISION
        {
            get{ return _field_precision; }
            set{ _field_precision = value; }
        }
		private decimal? _field_scale;
		/// <summary>
		/// 小数位数
        /// </summary>		
		[DataMember]
        public decimal? FIELD_SCALE
        {
            get{ return _field_scale; }
            set{ _field_scale = value; }
        }
		private decimal? _dic_type_id;
		/// <summary>
		/// 字典类型ID
        /// </summary>		
		[DataMember]
        public decimal? DIC_TYPE_ID
        {
            get{ return _dic_type_id; }
            set{ _dic_type_id = value; }
        }
		private decimal? _is_multi_select;
		/// <summary>
		/// 是否多选
        /// </summary>		
		[DataMember]
        public decimal? IS_MULTI_SELECT
        {
            get{ return _is_multi_select; }
            set{ _is_multi_select = value; }
        }
		private decimal? _check_null;
		/// <summary>
		/// 检查是否为空
        /// </summary>		
		[DataMember]
        public decimal? CHECK_NULL
        {
            get{ return _check_null; }
            set{ _check_null = value; }
        }
		private string _default;
		/// <summary>
		/// 默认值
        /// </summary>		
		[DataMember]
        public string Default
        {
            get{ return _default; }
            set{ _default = value; }
        }
		private decimal? _sort;
		/// <summary>
		/// 排序
        /// </summary>		
		[DataMember]
        public decimal? SORT
        {
            get{ return _sort; }
            set{ _sort = value; }
        }
		private DateTime? _created_time;
		/// <summary>
		/// 创建时间
        /// </summary>		
		[DataMember]
        public DateTime? CREATED_TIME
        {
            get{ return _created_time; }
            set{ _created_time = value; }
        }
		private decimal? _created_by;
		/// <summary>
		/// 创建人
        /// </summary>		
		[DataMember]
        public decimal? CREATED_BY
        {
            get{ return _created_by; }
            set{ _created_by = value; }
        }
		private DateTime? _modified_time;
		/// <summary>
		/// 修改时间
        /// </summary>		
		[DataMember]
        public DateTime? MODIFIED_TIME
        {
            get{ return _modified_time; }
            set{ _modified_time = value; }
        }
		private decimal? _modified_by;
		/// <summary>
		/// 修改人
        /// </summary>		
		[DataMember]
        public decimal? MODIFIED_BY
        {
            get{ return _modified_by; }
            set{ _modified_by = value; }
        }
		 
	}
}