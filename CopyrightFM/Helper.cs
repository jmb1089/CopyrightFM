﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CopyrightFM
{
    public static class Helper
    {
        public static string CNN(string name)
        {

            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            
        }
        
    }
}
