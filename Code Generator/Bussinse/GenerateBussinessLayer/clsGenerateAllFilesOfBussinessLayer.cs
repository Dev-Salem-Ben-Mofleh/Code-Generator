using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinse
{
    public class clsGenerateAllFilesOfBussinessLayer
    {
        clsBussiness _bussiness;

        public clsGenerateAllFilesOfBussinessLayer(clsBussiness bussiness)
        {
            _bussiness = bussiness;

        }
        public void GenerateAllFilesOfBussinessLayer(string FilePath, string DatabaseName)
        {
            StringBuilder ContentOfFile = new StringBuilder();

            for (int i = 0; i < _bussiness.Tables.Count; i++)
            {
                _bussiness.FillParamtersOfDataBase(DatabaseName, _bussiness.Tables[i]);
                string FileName = $"cls{_bussiness.Tables[i].Substring(0, _bussiness.Tables[i].Length - 1)}.cs";
                ContentOfFile.Append($"{_bussiness.GenerateBussinessLayer(_bussiness.Tables[i])}");
                string newFilePath = ($"{FilePath}\\{FileName}");
                File.WriteAllText(newFilePath, ContentOfFile.ToString());
                ContentOfFile.Clear();

            }
        }


    }
}
