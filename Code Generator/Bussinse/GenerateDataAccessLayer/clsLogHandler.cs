using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinse
{
    public class clsLogHandler
    {
        public static StringBuilder GenerateLogHandler(string NameSpace)
        {

            StringBuilder DataAccessLayer = new StringBuilder();

            DataAccessLayer.Append(
                $"using System;\r\n" +
                $"using System.Configuration;\r\n" +
                $"using System.Diagnostics;\r\n\r\n" +
                $"namespace {NameSpace}\r\n" +
                $"{{\r\n" +
                $"    public class clsLogHandler\r\n" +
                $"    {{\r\n" +
                $"        public static void LogToEventViewer(string errorType, Exception ex)\r\n" +
                $"        {{\r\n" +
                $"            string sourceName = ConfigurationManager.AppSettings[\"ProjectName\"]; \r\n\r\n" +
                $"            // Create the event source if it does not exist\r\n" +
                $"            if (!EventLog.SourceExists(sourceName))\r\n " +
                $"           {{\r\n" +
                $"                EventLog.CreateEventSource(sourceName, \"Application\"); \r\n" +
                $"            }}\r\n\r\n" +
                $"            string errorMessage = $\"{{errorType}} in {{ex.Source}}\\n\\nException Message:\" +\r\n" +
                $"                    $\" {{ex.Message}}\\n\\nException Type: {{ex.GetType().Name}}\\n\\nStack Trace:\" +\r\n" +
                $"                    $\" {{ex.StackTrace}}\\n\\nException Location: {{ex.TargetSite}}\";\r\n\r\n" +
                $"            // Log an error event\r\n" +
                $"            EventLog.WriteEntry(sourceName, errorMessage, EventLogEntryType.Error);\r\n" +
                $"        }}\r\n" +
                $"    }}\r\n}}\r\n" 
                  );

            return DataAccessLayer;
        }

    }
}
