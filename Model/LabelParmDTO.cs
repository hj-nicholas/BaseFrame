using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LabelParmDTO
    {
        /// <summary>
        /// 1 InParm        
        /// 2 OutParm
        /// </summary>
        public decimal IN_OR_OUT { get; set; }

        public decimal FORM_LABEL_ID { get; set; }

        public string LABEL_NAME { get; set; }

        public string PARM_NAME { get; set; }

        //动作，返回参数改执行何种处理.
        public int ACTION { get; set; }
    }
}
