using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinse
{
    public class clsErrorLogger
    {
        public static StringBuilder GenerateErrorLogger(string NameSpace)
        {
            StringBuilder DataAccessSettings = new StringBuilder();

            DataAccessSettings.Append(
                $"using System;\r\n\r\n" +
                $"namespace {NameSpace}\r\n" +
                $"{{\r\n" +
                $"    public class clsErrorLogger\r\n" +
                $"    {{\r\n" +
                $"        private Action<string, Exception> _logAction;\r\n\r\n" +
                $"        public clsErrorLogger(Action<string, Exception> logAction)\r\n" +
                $"        {{\r\n" +
                $"            _logAction = logAction;\r\n" +
                $"        }}\r\n\r\n" +
                $"        public void LogError(string errorType, Exception ex)\r\n" +
                $"        {{\r\n" +
                $"            _logAction?.Invoke(errorType, ex);\r\n" +
                $"        }}\r\n" +
                $"    }}\r\n" +
                $"}}\r\n"
                );
            return DataAccessSettings;
        }
    }
}
