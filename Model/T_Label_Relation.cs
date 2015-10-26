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
    public partial class LabelRelationDTO
    {
        private decimal _id;
        /// <summary>
        /// ID
        /// </summary>		
        [DataMember]
        public decimal ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private decimal? _template_id;
        /// <summary>
        /// 模板ID
        /// </summary>		
        [DataMember]
        public decimal? TEMPLATE_ID
        {
            get { return _template_id; }
            set { _template_id = value; }
        }
        private decimal? _form_label_id;
        /// <summary>
        /// 表单标签ID
        /// </summary>		
        [DataMember]
        public decimal? FORM_LABEL_ID
        {
            get { return _form_label_id; }
            set { _form_label_id = value; }
        }
        private decimal? _rel_label_id;
        /// <summary>
        /// REL_LABEL_ID
        /// </summary>		
        [DataMember]
        public decimal? REL_LABEL_ID
        {
            get { return _rel_label_id; }
            set { _rel_label_id = value; }
        }
        private decimal? _rel_type;
        /// <summary>
        /// REL_TYPE
        /// </summary>		
        [DataMember]
        public decimal? REL_TYPE
        {
            get { return _rel_type; }
            set { _rel_type = value; }
        }
        private decimal? _rel_seq;
        /// <summary>
        /// REL_SEQ
        /// </summary>		
        [DataMember]
        public decimal? REL_SEQ
        {
            get { return _rel_seq; }
            set { _rel_seq = value; }
        }

    }
}
