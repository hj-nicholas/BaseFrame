using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class FormLabelDTO
    {
        public decimal FORM_FIELD_ID { get; set; }
        public string FORM_FIELD_NAME { get; set; }

        public string DIC_TYPE_NAME { get; set; }

        public IList<LabelDataDTO> BindDataList { get; set; }

        public string API_NAME { get; set; }

        public string API_URL { get; set; }

        public IList<LabelParmDTO> BindParmList { get; set; }
        public IList<LabelRelationDTO> BindRelationList { get; set; }

        public RedasDbFieldDTO FORM_FIELD { get; set; }

        public decimal OBJECT_TYPE_ID { get; set; }

        public decimal SORT { get; set; }

        public string FIELD_TYPE { get; set; }

        public decimal FIELD_LENGTH { get; set; }

        public string DIRECTORY_NAME { get; set; }
        public decimal? DEFAULT_ORDER { get; set; }

        public bool IsCheck { get; set; }

        //标签内容格式化规则
        public string FORMAT_VALUE { get; set; }

        //标签原始名称
        public string LABEL_NAME_ORI { get; set; }
        public bool IsSelected { get; set; }

    }
    public partial class FormLabelDTO2
    {
        public decimal FORM_LABEL_ID { get; set; }
        public string LABEL_NAME { get; set; }
        public string LABEL_NAME_CHS { get; set; }

    }
    public partial class FormInstanceDTO2
    {
        public decimal INSTANCE_ID { get; set; }
        public string INSTANCE_NAME { get; set; }

        public decimal INSTANCE_ORI_ID { get; set; }


    }
}
