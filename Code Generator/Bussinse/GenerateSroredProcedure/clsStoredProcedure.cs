using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bussinse
{
    public class clsStoredProcedure
    {

        clsBussiness _bussiness;
        string _connectionString;
        string _TableNameForOne;
        string _TableNamea;
        string _PrimeryKey;
        string _DatabaseName;

        public clsStoredProcedure(clsBussiness bussiness)
        {
            _bussiness = bussiness;

        }
        private string _GetPrimairyKay()
        {
            return _bussiness.PrimeryKeys;
        }
        private string _GitDataType(string DataType ,string MaXLength)
        {
            if (clsHleperMethods.IsString(DataType))
                return DataType+ "("+MaXLength+")";            
            else
                return DataType;
            
        }

        private string _GetAllParamtersForAddAndUpdate(bool WithPrimaryKeyOrNot,byte Add=1)
        {
            StringBuilder builder = new StringBuilder();
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

                builder.AppendLine($"@{Paramter} {_GitDataType(DatatypeAndNull[0],DatatypeAndNull[2])},");

            }
            if (Add == 1) 
            { return builder.ToString(); }
            else
            {
                builder = builder.Remove(builder.Length - 3, 1);
                return builder.ToString();

            }

        }
        private string _FillAllParamtersForAdd(bool WithPrimaryKeyOrNot,byte Value=1)
        {
            StringBuilder sDataTransLine = new StringBuilder();
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
                if(Value == 1)
                    sDataTransLine.Append($"{Paramter},");
                else
                    sDataTransLine.Append($"@{Paramter},");
            }



            sDataTransLine = sDataTransLine.Remove(sDataTransLine.Length - 1, 1);
            return sDataTransLine.ToString();
        }
        private string _FillAllParamtersForUpdate(bool WithPrimaryKeyOrNot)
        {
            StringBuilder sDataTransLine = new StringBuilder();
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
                    sDataTransLine.AppendLine($"{Paramter} = @{Paramter},");

            }

            sDataTransLine = sDataTransLine.Remove(sDataTransLine.Length - 3, 1);
            return sDataTransLine.ToString();
        }

        public void ExcuteStoredProcedureDircteInSql(string TableName, string DatabaseName)
        {
            _DatabaseName = DatabaseName;
            _TableNameForOne = TableName.Substring(0, TableName.Length - 1);
            _TableNamea = TableName;
             _PrimeryKey = _GetPrimairyKay();
            _connectionString = $"Server=.;Database={_DatabaseName};User Id=sa;Password=sa123456;";

            _SaveAddStordeProcedure();
                _SaveUpdateStordeProcedure();
                _SaveDeleteStordeProcedure();
                _SaveGetAllStordeProcedure();
                _SaveGetByIDStordeProcedure();
                _SaveGetExistsStordeProcedure();

        }
        public StringBuilder GenerateStoredProcedure(string TableName)
        {
            StringBuilder StoredProcudure = new StringBuilder();
            _TableNameForOne = TableName.Substring(0, TableName.Length - 1);
            _TableNamea = TableName;
            _PrimeryKey = _GetPrimairyKay();

            StoredProcudure.Append
                ($"CREATE PROCEDURE SP_AddNew{_TableNameForOne}\r\n" +
                 $"                 {_GetAllParamtersForAddAndUpdate(true)}\n" +
                 $"                 @New{_PrimeryKey} INT OUTPUT\r\n" +
                 $"                 AS\r\n" +
                 $"                 BEGIN\r\n" +
                 $"                 INSERT INTO {_TableNamea} ({_FillAllParamtersForAdd(true)})\r\n" +
                 $"                 VALUES ({_FillAllParamtersForAdd(true, 0)});\r\n\r\n\r\n" +
                 $"                 SET @New{_PrimeryKey} = SCOPE_IDENTITY();\r\n" +
                 $"END\r\n" +
                 $"=========================" +
                 $"=========================\r\n" +
                 $"CREATE PROCEDURE SP_Update{_TableNameForOne}\r\n" +
                 $"                     @{_PrimeryKey} INT,\r\n" +
                 $"                    {_GetAllParamtersForAddAndUpdate(true, 0)}\r\n" +
                 $"                     AS\r\n" +
                 $"                     BEGIN\r\n" +
                 $"                     UPDATE {_TableNamea}\r\n" +
                 $"                     SET {_FillAllParamtersForUpdate(true)}\r\n" +
                 $"                     WHERE {_PrimeryKey} = @{_PrimeryKey}\r\n" +
                 $"                     END\r\n" +
                 $"=========================" +
                 $"=========================\r\n " +
                 $"CREATE PROCEDURE SP_Delete{_TableNameForOne}\r\n " +
                 $"                            @{_PrimeryKey} INT\r\n" +
                 $"                             AS\r\n" +
                 $"                             BEGIN\r\n" +
                 $"                             DELETE FROM {_TableNamea} WHERE {_PrimeryKey} = @{_PrimeryKey}\r\n" +
                 $"                             END\r\n" +
                 $"=========================" +
                 $"=========================\r\n " +
                 $"CREATE PROCEDURE SP_GetAll{_TableNamea}\r\n" +
                 $"                                        AS\r\n " +
                 $"                                       BEGIN\r\n" +
                 $"                                        SELECT * FROM {_TableNamea}\r\n" +
                 $"                                        END\r\n" +
                 $"=========================" +
                 $"=========================\r\n" +
                 $"CREATE PROCEDURE SP_Get{_TableNameForOne}ByID\r\n" +
                 $"                                        @{_PrimeryKey} INT\r\n" +
                 $"                                        AS\r\n" +
                 $"                                        BEGIN\r\n" +
                 $"                                        SELECT* FROM {_TableNamea} WHERE {_PrimeryKey} = @{_PrimeryKey}\r\n" +
                 $"                                        END\r\n" +
                 $"=========================" +
                 $"=========================\r\n" +
                 $"CREATE PROCEDURE SP_Check{_TableNameForOne}Exists\r\n" +
                 $"                                        @{_PrimeryKey} INT\r\n" +
                 $"                                         AS\r\n" +
                 $"                                         BEGIN\r\n" +
                 $"                                         IF EXISTS(SELECT * FROM {_TableNamea} WHERE {_PrimeryKey} = @{_PrimeryKey})\r\n" +
                 $"                                         RETURN 1;  \r\n" +
                 $"                                         ELSE\r\n" +
                 $"                                         RETURN 0;\r\n" +
                 $"                                         END"


                );
                return StoredProcudure;

        }

        private void _SaveAddStordeProcedure()
        {


            // كود SQL لإنشاء الدالة المخزنة
            string storedProcedure = $@"
            CREATE PROCEDURE SP_AddNew{_TableNameForOne}
                 {_GetAllParamtersForAddAndUpdate(true)}
                 @New{_PrimeryKey} INT OUTPUT
                 AS
                 BEGIN
                 INSERT INTO {_TableNamea} ({_FillAllParamtersForAdd(true)})
                 VALUES ({_FillAllParamtersForAdd(true,0)});


                 SET @New{_PrimeryKey} = SCOPE_IDENTITY();
                 END";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        // تنفيذ كود SQL لإنشاء الدالة المخزنة
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void _SaveUpdateStordeProcedure()
        {


            // كود SQL لإنشاء الدالة المخزنة
            string storedProcedure = $@"CREATE PROCEDURE SP_Update{_TableNameForOne}
                     @{_PrimeryKey} INT,
                    {_GetAllParamtersForAddAndUpdate(true, 0)}
                     AS
                     BEGIN
                     UPDATE {_TableNamea}
                      SET {_FillAllParamtersForUpdate(true)}
                     WHERE {_PrimeryKey} = @{_PrimeryKey}
                     END";


            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        // تنفيذ كود SQL لإنشاء الدالة المخزنة
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void _SaveDeleteStordeProcedure()
        {


            string storedProcedure = $@"
                             CREATE PROCEDURE SP_Delete{_TableNameForOne}
                             @{_PrimeryKey} INT
                             AS
                             BEGIN
                             DELETE FROM {_TableNamea} WHERE {_PrimeryKey} = @{_PrimeryKey}
                             END";

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        // تنفيذ كود SQL لإنشاء الدالة المخزنة
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void _SaveGetAllStordeProcedure()
        {


            string storedProcedure = $@"CREATE PROCEDURE SP_GetAll{_TableNamea}
                                        AS
                                        BEGIN
                                        SELECT * FROM {_TableNamea}
                                        END";


            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        // تنفيذ كود SQL لإنشاء الدالة المخزنة
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void _SaveGetByIDStordeProcedure()
        {


            string storedProcedure = $@"CREATE PROCEDURE SP_Get{_TableNameForOne}ByID
                                        @{_PrimeryKey} INT
                                        AS
                                        BEGIN
                                        SELECT* FROM {_TableNamea} WHERE {_PrimeryKey} = @{_PrimeryKey}
                                        END";


            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        // تنفيذ كود SQL لإنشاء الدالة المخزنة
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void _SaveGetExistsStordeProcedure()
        {


            string storedProcedure = $@"CREATE PROCEDURE SP_Check{_TableNameForOne}Exists
                                        @{_PrimeryKey} INT
                                         AS
                                         BEGIN
                                         IF EXISTS(SELECT * FROM {_TableNamea} WHERE {_PrimeryKey} = @{_PrimeryKey})
                                         RETURN 1;  
                                         ELSE
                                         RETURN 0;
                                         END";


            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                    {
                        // تنفيذ كود SQL لإنشاء الدالة المخزنة
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

    }



}
