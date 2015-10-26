using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DataAccess
{
    public class OriDBHelper : BaseDB
    {
        protected override string connectionString
        {
            get { return ConfigurationManager.ConnectionStrings["OriDB"].ConnectionString; }
        }
    }
}
