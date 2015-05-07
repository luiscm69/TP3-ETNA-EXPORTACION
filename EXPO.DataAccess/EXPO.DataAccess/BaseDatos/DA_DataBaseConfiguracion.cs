using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace EXPO.DataAccess.BaseDatos
{
    public static class DataBaseHelper
    {
        public static string GetDbProvider()
        {
            return ConfigurationManager.ConnectionStrings["DB_ETNA"].ProviderName;
        }
        public static string GetDbConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DB_ETNA"].ConnectionString;
        }
    }
}
