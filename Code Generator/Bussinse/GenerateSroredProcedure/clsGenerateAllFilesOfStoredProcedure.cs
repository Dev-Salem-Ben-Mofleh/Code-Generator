using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinse
{
    public class clsGenerateAllFilesOfStoredProcedure
    {
        clsBussiness _bussiness;

        public clsGenerateAllFilesOfStoredProcedure(clsBussiness bussiness)
        {
            _bussiness = bussiness;
        }

        public void GenerateAllFilesOfStoredProcedure( string DatabaseName)
        {
            StringBuilder ContentOfFile = new StringBuilder();
            
                for (int i = 0; i < _bussiness.Tables.Count; i++)
                {
                    _bussiness.FillParamtersOfDataBase(DatabaseName, _bussiness.Tables[i]);
                    _bussiness.ExcuteStoredProcedureDircteInSql(_bussiness.Tables[i], DatabaseName);
                }
            }
           

    }
}
