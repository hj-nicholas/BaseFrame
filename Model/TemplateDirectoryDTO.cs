using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class TemplateDirectoryDTO
    {
        [DataMember]
        public decimal? SORT_DISPLAY { get { return this.SORT; }  }

        [DataMember]
        public string DIRECTORY_NAME { get; set; }
    }
}
