using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class EGJDBHelper : BaseDB
    {
        protected override string connectionString
        {
            get { return ConfigurationManager.ConnectionStrings["EGJDB"].ConnectionString; }
        }

    }


}
