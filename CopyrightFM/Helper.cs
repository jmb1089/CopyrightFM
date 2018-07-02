using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyrightFM
{
    public static class Helper
    {
        public static string CNN(string name)
        {

            return ConfigurationManager.ConnectionStrings[].ConnectionString;
        }
    }
}
