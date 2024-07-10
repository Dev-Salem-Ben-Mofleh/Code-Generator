using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Bussinse
{
    public class clsAppConfig
    {
        public static StringBuilder GenerateAppConfig(string DatabaseName)
        {
            StringBuilder AppConfig = new StringBuilder();
            AppConfig.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            AppConfig.AppendLine("<configuration>");
            AppConfig.AppendLine();
            AppConfig.AppendLine("\t<startup>");
            AppConfig.AppendLine("\t\t<supportedRuntime version=\"v4.0\" sku=\".NETFramework,Version=v4.8\" />");
            AppConfig.AppendLine("\t</startup>");
            AppConfig.AppendLine();
            AppConfig.AppendLine("\t<appSettings>");
            AppConfig.AppendLine($"\t\t<add key=\"ProjectName\" value=\"{DatabaseName}\" />");
            AppConfig.AppendLine("\t</appSettings>");
            AppConfig.AppendLine();
            AppConfig.AppendLine("\t<connectionStrings>");
            AppConfig.AppendLine($"\t\t<add name=\"ConnectionString\" connectionString=\"Server=.;Database={DatabaseName};Integrated Security=True;\" providerName=\"System.Data.SqlClient\" />");
            AppConfig.AppendLine("\t</connectionStrings>");
            AppConfig.AppendLine();
            AppConfig.AppendLine("</configuration>");


            return AppConfig;
        }
        public static void GenerateAppConfig(string FilePath, string DatabaseName)
        {
            File.WriteAllText(FilePath + "\\App.config", GenerateAppConfig(DatabaseName).ToString());

        }
    }
}
