using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinse
{
    public class clsDataAccessHelper
    {
        public static StringBuilder GenerateDataAcesssHelper(string NameSpace)
        {
       
            StringBuilder DataAccessLayer = new StringBuilder();

            DataAccessLayer.Append(
                $"using System;\r\n" +
                $"using System.Data;\r\n" +
                $"using System.Data.SqlClient;\r\n\r\n" +
                $"namespace {NameSpace}\r\n" +
                $"{{\r\n" +
                $"    public static class clsDataAccessHelper\r\n" +
                $"    {{\r\n" +
                $"        public static int Count(string StoredProcedureName)\r\n" +
                $"        {{\r\n" +
                $"            int Count = 0;\r\n\r\n" +
                $"            try\r\n" +
                $"            {{\r\n" +
                $"                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))\r\n" +
                $"                {{\r\n" +
                $"                    connection.Open();\r\n\r\n" +
                $"                    using (SqlCommand command = new SqlCommand(StoredProcedureName, connection))\r\n" +
                $"                    {{\r\n" +
                $"                        command.CommandType = CommandType.StoredProcedure;\r\n\r\n" +
                $"                        object result = command.ExecuteScalar();\r\n\r\n" +
                $"                        if (result != null && int.TryParse(result.ToString(), out int Value))\r\n" +
                $"                        {{\r\n" +
                $"                            Count = Value;\r\n" +
                $"                        }}\r\n" +
                $"                   }}\r\n" +
                $"                }}\r\n" +
                $"            }}\r\n" +
                $"            catch (SqlException ex)\r\n" +
                $"            {{\r\n" +
                $"                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);\r\n" +
                $"                loggerToEventViewer.LogError(\"Database Exception\", ex);\r\n" +
                $"            }}\r\n" +
                $"            catch (Exception ex)\r\n" +
                $"            {{\r\n" +
                $"                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);\r\n" +
                $"                loggerToEventViewer.LogError(\"General Exception\", ex);\r\n" +
                $"            }}\r\n\r\n" +
                $"            return Count;\r\n" +
                $"        }}\r\n\r\n" +
                $"        public static DataTable GetAll(string StoredProcedureName)\r\n" +
                $"        {{\r\n" +
                $"            DataTable dt = new DataTable();\r\n\r\n" +
                $"            try\r\n" +
                $"            {{\r\n" +
                $"                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))\r\n" +
                $"                {{\r\n" +
                $"                    connection.Open();\r\n\r\n" +
                $"                    using (SqlCommand command = new SqlCommand(StoredProcedureName, connection))\r\n" +
                $"                    {{\r\n" +
                $"                        command.CommandType = CommandType.StoredProcedure;\r\n\r\n" +
                $"                        using (SqlDataReader reader = command.ExecuteReader())\r\n" +
                $"                        {{\r\n" +
                $"                            if (reader.HasRows)\r\n" +
                $"                            {{\r\n" +
                $"                                dt.Load(reader);\r\n" +
                $"                            }}\r\n" +
                $"                        }}\r\n" +
                $"                    }}\r\n" +
                $"                }}\r\n" +
                $"            }}\r\n" +
                $"            catch (SqlException ex)\r\n" +
                $"            {{\r\n" +
                $"                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);\r\n" +
                $"                loggerToEventViewer.LogError(\"Database Exception\", ex);\r\n" +
                $"            }}\r\n" +
                $"            catch (Exception ex)\r\n" +
                $"            {{\r\n" +
                $"                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);\r\n" +
                $"                loggerToEventViewer.LogError(\"General Exception\", ex);\r\n" +
                $"            }}\r\n\r\n" +
                $"            return dt;\r\n" +
                $"        }}\r\n" +
                $"    }}\r\n" +
                $"}}\r\n"
                );

            return DataAccessLayer;
        }
    }
}
