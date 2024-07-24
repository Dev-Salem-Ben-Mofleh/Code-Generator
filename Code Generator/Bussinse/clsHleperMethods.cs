using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Net.Http;


namespace DataAccess
{
    public class clsDataAccess
    {
        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString()))
                {
                    connection.Open();

                    string query = @"SELECT name AS DatabaseName
                             FROM sys.databases
                             WHERE database_id > 4
                             ORDER BY create_date DESC";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("Database Exception", ex);
            }
            catch (Exception ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("General Exception", ex);
            }

            return dt;
        }

        public static void FillTablesOfDataBase(string DatabaseName, ref List<string> Tables)
        {

            DataTable tables = _GetAllTablesNameInASpecificDatabase(DatabaseName);

            foreach (DataRow table in tables.Rows)
            {

                string tableName = table["TableName"].ToString();
                Tables.Add(tableName);

            }
        }
        private static DataTable _GetAllTablesNameInASpecificDatabase(string DatabaseName)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString(DatabaseName)))
                {
                    connection.Open();

                    string query = @"SELECT name AS TableName
                                 FROM sys.tables 
                                 WHERE name <> 'sysdiagrams'
                                 Order by name;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("Database Exception", ex);
            }
            catch (Exception ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("General Exception", ex);
            }

            return dt;
        }

        private static DataTable _GetColumnsNameWithInfo(string tableName, string databaseName)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString(databaseName)))
                {
                    connection.Open();

                    string query = @"SELECT
                                 COLUMN_NAME ,
                                 DATA_TYPE ,
                                 IS_NULLABLE ,
                                 CHARACTER_MAXIMUM_LENGTH 
                             FROM
                                 INFORMATION_SCHEMA.COLUMNS
                             WHERE
                                 TABLE_NAME = @TableName
                             ORDER BY
                                 ORDINAL_POSITION;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableName", tableName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("Database Exception", ex);
            }
            catch (Exception ex)
            {
                clsErrorLogger loggerToEventViewer = new clsErrorLogger(clsLogHandler.LogToEventViewer);
                loggerToEventViewer.LogError("General Exception", ex);
            }


            return dt;
        }

        public static void FillParamtersOfDataBase(string DatabaseName, string TableName, ref SortedDictionary<string, string> Parametrs, ref string PrimeryKeys)
        {
            DataTable dataTable = _GetColumnsNameWithInfo(TableName, DatabaseName);
            foreach (DataRow column in dataTable.Rows)
            {
                string columnName = column["COLUMN_NAME"].ToString();
                string dataType = column["DATA_TYPE"].ToString();
                string isNullable = column["IS_NULLABLE"].ToString();
                string CHARACTER_MAXIMUM_LENGTH = column["CHARACTER_MAXIMUM_LENGTH"].ToString();

                Parametrs.Add(columnName, dataType + "," + isNullable+","+ CHARACTER_MAXIMUM_LENGTH);
                if (PrimeryKeys=="")
                {
                    PrimeryKeys = columnName;
                }

            }
        }
    }
}
