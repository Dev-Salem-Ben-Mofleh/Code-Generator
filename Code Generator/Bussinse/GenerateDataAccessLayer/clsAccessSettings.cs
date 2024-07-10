using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinse
{
    public class clsAccessSettings
    {   
        public static StringBuilder GenerateAcesssSetting(string NameSpace)
        {
            StringBuilder DataAccessSettings = new StringBuilder();

                DataAccessSettings.Append(
                    $"using System.Configuration;" +
                    $"\r\n\r\n namespace {NameSpace}" +
                    $"\r\n" +
                    $"{{\r\n" +
                    $"    public static class clsDataAccessSettings\r\n" +
                    $"    {{ \r\n" +
                    $"        public static string ConnectionString = ConfigurationManager.ConnectionStrings[\"ConnectionString\"].ConnectionString;\r\n" +
                    $"    }}" +
                    $"\r\n}} "
                    );
            return DataAccessSettings;
        }
    }
}
