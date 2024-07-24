using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bussinse
{
    public class clsDataAccessLayer
    {
        clsBussiness _bussiness;

        public clsDataAccessLayer(clsBussiness bussiness)
        {
            _bussiness = bussiness;

        }
        private string _GetPrimairyKay()
        {
            return _bussiness.PrimeryKeys;
        }


        private StringBuilder _GetAllParamtersForFind( bool WithPrimaryKeyOrNot)
        {
            StringBuilder AllParamters = new StringBuilder();
            string Paramter = "";

                    foreach (KeyValuePair<string, string> Parametrs in _bussiness.Parametrs)
                    {

                            Paramter = Parametrs.Key;
                            List<string> DatatypeAndNull = Parametrs.Value.Split(',').ToList();
                            if (WithPrimaryKeyOrNot)
                            {
                                if (_GetPrimairyKay() == Paramter)
                                {
                                    WithPrimaryKeyOrNot = false;
                                    continue;
                                }
                            }
                if (clsHleperMethods.IsInt(DatatypeAndNull[0]))
                {
                    AllParamters.Append($"ref {clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter},");

                }
                else
                {
                    if (clsHleperMethods.IsString(DatatypeAndNull[0]))
                    {
                            AllParamters.Append($"ref {clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter},");
                    }
                    else
                    {
                        if (DatatypeAndNull[1]=="NO")
                            AllParamters.Append($"ref {clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter},");
                        else
                            AllParamters.Append($"ref {clsHleperMethods.GitDataType(DatatypeAndNull[0])}? {Paramter},");


                    }
                }

                        }

                    
                
            return (AllParamters.Remove(AllParamters.Length -1, 1));
        }
        private StringBuilder _FillAllParamtersForFind( bool WithPrimaryKeyOrNot)
        
        
        {
            StringBuilder AllParamters = new StringBuilder();
            string Paramter = "";

            foreach (KeyValuePair<string, string> Parametrs in _bussiness.Parametrs)
            {
                Paramter = Parametrs.Key;
                List<string> DatatypeAndNull = Parametrs.Value.Split(',').ToList();
                if (WithPrimaryKeyOrNot)
                {
                    if (_GetPrimairyKay() == Paramter)
                    {
                        WithPrimaryKeyOrNot = false;
                        continue;
                    }
                }
                if (DatatypeAndNull[0] == "int")
                {
                    AllParamters.Append(
                                                   $" {Paramter} = (reader[\"{Paramter}\"] != DBNull.Value) ? ({clsHleperMethods.GitDataType(DatatypeAndNull[0])})reader[\"{Paramter}\"] : null;\r\n");
                }
                else
                {
                    if (DatatypeAndNull[0] == "nvarchar" || DatatypeAndNull[0] == "varchar" || DatatypeAndNull[0] == "nchar")
                    {
                        if (DatatypeAndNull[1] == "NO")
                            AllParamters.Append(
                                                 $" {Paramter}= ({clsHleperMethods.GitDataType(DatatypeAndNull[0])})reader[\"{Paramter}\"];\r\n");
                        else
                            AllParamters.Append(
                                                  $" {Paramter} = (reader[\"{Paramter}\"] != DBNull.Value) ? ({clsHleperMethods.GitDataType(DatatypeAndNull[0])})reader[\"{Paramter}\"] : null;\r\n");
                    }
                    else
                    {
                        if (DatatypeAndNull[1] == "NO")
                            AllParamters.Append(
                                                                    $" {Paramter}= ({clsHleperMethods.GitDataType(DatatypeAndNull[0])})reader[\"{Paramter}\"];\r\n");
                        else
                            AllParamters.Append(
                                                           $" {Paramter} = (reader[\"{Paramter}\"] != DBNull.Value) ? ({clsHleperMethods.GitDataType(DatatypeAndNull[0])}?)reader[\"{Paramter}\"] : null;\r\n");

                    }
                }
            }

                    
            return AllParamters;
        }



        private StringBuilder _GetAllParamtersForAddAndUpdate( bool WithPrimaryKeyOrNot)
        {

            StringBuilder AllParamters = new StringBuilder();
            string Paramter = "";


            foreach (KeyValuePair<string, string> Parametrs in _bussiness.Parametrs)
            {

                Paramter = Parametrs.Key;
                List<string> DatatypeAndNull = Parametrs.Value.Split(',').ToList();
                if (WithPrimaryKeyOrNot)
                {
                    if (_GetPrimairyKay() == Paramter)
                    {
                        WithPrimaryKeyOrNot = false;
                        continue;
                    }
                }
                if (clsHleperMethods.IsInt(DatatypeAndNull[0]))
                {
                    AllParamters.Append($"{clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter},");

                }
                else
                {
                    if (clsHleperMethods.IsString(DatatypeAndNull[0]))
                    {
                        AllParamters.Append($"{clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter},");
                    }
                    else
                    {
                        if (DatatypeAndNull[1] == "NO")
                            AllParamters.Append($"{clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter},");
                        else
                            AllParamters.Append($"{clsHleperMethods.GitDataType(DatatypeAndNull[0])}? {Paramter},");


                    }
                }
            }
            return (AllParamters.Remove(AllParamters.Length - 1, 1));
        }
        private StringBuilder _FillAllParamtersForAddAndUpadte( bool WithPrimaryKeyOrNot)
        {

            StringBuilder AllParamters = new StringBuilder();
            string Paramter = "";

            foreach (KeyValuePair<string, string> Parametrs in _bussiness.Parametrs)
            {

                Paramter = Parametrs.Key;
                List<string> DatatypeAndNull = Parametrs.Value.Split(',').ToList();
                if (WithPrimaryKeyOrNot)
                {
                    if (_GetPrimairyKay() == Paramter)
                    {
                        WithPrimaryKeyOrNot = false;
                        continue;
                    }
                }
                
                if (DatatypeAndNull[1] == "NO" && !clsHleperMethods.IsInt(DatatypeAndNull[0]))
                    AllParamters.AppendLine(
                                        $"command.Parameters.AddWithValue(\"@{Paramter}\", {Paramter});\r\n");
                else
                {
                    AllParamters.AppendLine($"command.Parameters.AddWithValue(\"@{Paramter}\", (object){Paramter} ?? DBNull.Value);\r\n");
                }

            }
            AllParamters = AllParamters.AppendLine("\r\n\r\n");
            return AllParamters;
        }

        public StringBuilder GenerateDataAcesss(string TableName )
        {
            string TableNameForOne = TableName.Substring(0, TableName.Length - 1);
            string PrimeryKey = _GetPrimairyKay();
            StringBuilder DataAccessLayer = new StringBuilder();

            DataAccessLayer.Append(
                $"using System;\r\n" +
            $"using System.Data;\r\n" +
            $"using System.Data.SqlClient;\r\n\r\n" +
            $"namespace InstituteDataAccess \r\n" +
            $"{{\r\n" +
            $"    public class cls{TableNameForOne}Data\r\n" +
            $"    {{\r\n" +
            $"        public static bool Get{TableNameForOne}InfoByID(int? {PrimeryKey},{_GetAllParamtersForFind( true)})\r\n" +
            $"        {{\r\n" +
            $"            bool IsFound = false;\r\n\r\n" +
            $"            try\r\n" +
            $"            {{\r\n" +
            $"                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))\r\n" +
            $"                {{\r\n" +
            $"                    connection.Open();\r\n\r\n" +
            $"                    using (SqlCommand command = new SqlCommand(\"SP_Get{TableNameForOne}InfoByID\", connection))\r\n" +
            $"                    {{\r\n" +
            $"                        command.CommandType = CommandType.StoredProcedure;\r\n\r\n" +
            $"                        command.Parameters.AddWithValue(\"@{PrimeryKey}\", (object){PrimeryKey} ?? DBNull.Value);\r\n\r\n" +
            $"                        using (SqlDataReader reader = command.ExecuteReader())\r\n" +
            $"                        {{\r\n" +
            $"                            if (reader.Read())\r\n" +
            $"                            {{\r\n" +
            $"                                // The record was found\r\n" +
            $"                                IsFound = true;\r\n\r\n" +
            $"                                {_FillAllParamtersForFind( true)}" +
            $"                            }}\r\n" +
            $"                            else\r\n" +
            $"                            {{\r\n" +
            $"                                // The record was not found\r\n" +
            $"                                IsFound = false;\r\n" +
            $"                            }}\r\n" +
            $"                        }}\r\n" +
            $"                    }}\r\n" +
            $"                }}\r\n" +
            $"            }}\r\n" +
            $"            catch (SqlException ex)\r\n" +
            $"            {{\r\n" +
            $"                IsFound = false;\r\n\r\n" +
            $"                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);\r\n" +
            $"                loggerToEventViewer.LogError(\"Database Exception\", ex);\r\n" +
            $"            }}\r\n" +
            $"            catch (Exception ex)\r\n" +
            $"            {{\r\n" +
            $"                IsFound = false;\r\n\r\n" +
            $"                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);\r\n" +
            $"                loggerToEventViewer.LogError(\"General Exception\", ex);\r\n" +
            $"            }}\r\n\r\n" +
            $"            return IsFound;\r\n" +
            $"        }}\r\n\r\n" +
            $"        public static int? AddNew{TableNameForOne}({_GetAllParamtersForAddAndUpdate( true)})\r\n" +
            $"        {{\r\n" +
            $"            // This function will return the new person id if succeeded and null if not\r\n" +
            $"            int? {PrimeryKey} = null;\r\n\r\n" +
            $"            try\r\n" +
            $"            {{\r\n" +
            $"                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))\r\n" +
            $"                {{\r\n" +
            $"                    connection.Open();\r\n\r\n" +
            $"                    using (SqlCommand command = new SqlCommand(\"SP_AddNew{TableNameForOne}\", connection))\r\n" +
            $"                    {{\r\n" +
            $"                        command.CommandType = CommandType.StoredProcedure;\r\n\r\n" +
            $"                        {_FillAllParamtersForAddAndUpadte( true)}" +
            $"                        SqlParameter outputIdParam = new SqlParameter(\"@New{PrimeryKey}\", SqlDbType.Int)\r\n" +
            $"                        {{\r\n" +
            $"                            Direction = ParameterDirection.Output\r\n" +
            $"                        }};\r\n" +
            $"                        command.Parameters.Add(outputIdParam);\r\n\r\n" +
            $"                        command.ExecuteNonQuery();\r\n\r\n" +
            $"                        {PrimeryKey} = (int?)outputIdParam.Value;\r\n" +
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
            $"            return {PrimeryKey};\r\n" +
            $"        }}\r\n\r\n" +
            $"        public static bool Update{TableNameForOne}(int? {PrimeryKey},{_GetAllParamtersForAddAndUpdate( true)} )\r\n" +
            $"        {{\r\n" +
            $"            int RowAffected = 0;\r\n\r\n" +
            $"            try\r\n" +
            $"            {{\r\n" +
            $"                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))\r\n" +
            $"                {{\r\n" +
            $"                    connection.Open();\r\n\r\n" +
            $"                    using (SqlCommand command = new SqlCommand(\"SP_Update{TableNameForOne}\", connection))\r\n" +
            $"                    {{\r\n" +
            $"                        command.CommandType = CommandType.StoredProcedure;\r\n\r\n" +
            $"                        {_FillAllParamtersForAddAndUpadte( false)}" +
            $"                        RowAffected = command.ExecuteNonQuery();\r\n" +
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
            $"            return (RowAffected > 0);\r\n" +
            $"        }}\r\n\r\n" +
            $"        public static bool Delete{TableNameForOne}(int? {PrimeryKey})\r\n" +
            $"        {{\r\n" +
            $"            int RowAffected = 0;\r\n\r\n" +
            $"            try\r\n" +
            $"            {{\r\n" +
            $"                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))\r\n" +
            $"                {{\r\n" +
            $"                    connection.Open();\r\n\r\n" +
            $"                    using (SqlCommand command = new SqlCommand(\"SP_Delete{TableNameForOne}\", connection))\r\n" +
            $"                    {{\r\n" +
            $"                        command.CommandType = CommandType.StoredProcedure;\r\n\r\n" +
            $"                        command.Parameters.AddWithValue(\"@{PrimeryKey}\", (object){PrimeryKey} ?? DBNull.Value);\r\n\r\n" +
            $"                        RowAffected = command.ExecuteNonQuery();\r\n" +
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
            $"            return (RowAffected > 0);\r\n" +
            $"        }}\r\n\r\n" +
            $"        public static bool Does{TableNameForOne}Exist(int? {PrimeryKey})\r\n" +
            $"        {{\r\n" +
            $"            bool IsFound = false;\r\n\r\n" +
            $"            try\r\n" +
            $"            {{\r\n" +
            $"                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))\r\n" +
            $"                {{\r\n" +
            $"                    connection.Open();\r\n\r\n" +
            $"                    using (SqlCommand command = new SqlCommand(\"SP_Does{TableNameForOne}Exist\", connection))\r\n" +
            $"                    {{\r\n" +
            $"                        command.CommandType = CommandType.StoredProcedure;\r\n\r\n" +
            $"                        command.Parameters.AddWithValue(\"@{PrimeryKey}\", (object){PrimeryKey} ?? DBNull.Value);\r\n\r\n" +
            $"                        // @ReturnVal could be any name, and we don't need to add it to the SP, just use it here in the code.\r\n" +
            $"                        SqlParameter returnParameter = new SqlParameter(\"@ReturnVal\", SqlDbType.Int)\r\n" +
            $"                        {{\r\n" +
            $"                            Direction = ParameterDirection.ReturnValue\r\n" +
            $"                        }};\r\n" +
            $"                        command.Parameters.Add(returnParameter);\r\n\r\n" +
            $"                        command.ExecuteNonQuery();\r\n\r\n" +
            $"                        IsFound = (int)returnParameter.Value == 1;\r\n" +
            $"                    }}\r\n" +
            $"                }}\r\n" +
            $"            }}\r\n" +
            $"            catch (SqlException ex)\r\n" +
            $"            {{\r\n" +
            $"                IsFound = false;\r\n\r\n" +
            $"                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);\r\n" +
            $"                loggerToEventViewer.LogError(\"Database Exception\", ex);\r\n" +
            $"            }}\r\n" +
            $"            catch (Exception ex)\r\n" +
            $"            {{\r\n" +
            $"                IsFound = false;\r\n\r\n" +
            $"                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);\r\n" +
            $"                loggerToEventViewer.LogError(\"General Exception\", ex);\r\n" +
            $"            }}\r\n\r\n" +
            $"            return IsFound;\r\n" +
            $"        }}\r\n\r\n" +
            $"        public static DataTable GetAll{TableName}()\r\n" +
            $"        {{\r\n" +
            $"            return clsDataAccessHelper.GetAll(\"SP_GetAll{TableName}\");\r\n" +
            $"        }}\r\n\r\n\r\n" +
            $"    }}\r\n}}\r\n"
            );

            return DataAccessLayer;
        }


    }
    
} 