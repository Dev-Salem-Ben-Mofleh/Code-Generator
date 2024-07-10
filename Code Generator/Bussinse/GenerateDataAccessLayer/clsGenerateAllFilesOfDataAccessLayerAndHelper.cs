using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinse
{
    public class clsGenerateAllFilesOfDataAccessLayerAndHelper
    {
        clsBussiness _bussiness;

        public clsGenerateAllFilesOfDataAccessLayerAndHelper(clsBussiness bussiness)
        {
            _bussiness = bussiness;

        }
        private void _GenertateAccessHelper(string FilePath)
        {
            StringBuilder ContentOfFile = new StringBuilder();

            string FileName = $"clsDataAccessHelper.cs";
             ContentOfFile.Append( $"{_bussiness.GenerateDataAcesssHelper(_bussiness.NameSpaceDataAccess)}");
            string newFilePath = ($"{FilePath}\\{FileName}");
            File.WriteAllText(newFilePath, ContentOfFile.ToString());
        }
        private void _GenertateAccessSetting(string FilePath)
        {
            StringBuilder ContentOfFile = new StringBuilder();

            string FileName = $"clsDataAccessSettings.cs";
             ContentOfFile.Append($"{_bussiness.GenerateAcesssSetting(_bussiness.NameSpaceDataAccess)}");
            string newFilePath = ($"{FilePath}\\{FileName}");
            File.WriteAllText(newFilePath, ContentOfFile.ToString());
        }
        private void _GenertateErrorLogger(string FilePath)
        {
            StringBuilder ContentOfFile = new StringBuilder();

            string FileName = $"clsErrorLogger.cs";
             ContentOfFile.Append($"{_bussiness.GenerateErrorLogger(_bussiness.NameSpaceDataAccess)}");
            string newFilePath = ($"{FilePath}\\{FileName}");
            File.WriteAllText(newFilePath, ContentOfFile.ToString());
        }
        private void _GenertateLogHandler(string FilePath)
        {
            StringBuilder ContentOfFile = new StringBuilder();

            string FileName = $"clsLogHandler.cs";
             ContentOfFile.Append($"{_bussiness.GenerateLogHandler(_bussiness.NameSpaceDataAccess)}");
            string newFilePath = ($"{FilePath}\\{FileName}");
            File.WriteAllText(newFilePath, ContentOfFile.ToString());

        }
        private void _GenerateAllFilesOfDataAccessHelper(string FilePath)
        {
            _GenertateAccessHelper(FilePath );
            _GenertateAccessSetting(FilePath);
            _GenertateErrorLogger(FilePath );
            _GenertateLogHandler(FilePath );

        }
        public void GenerateAllFilesOfDataAccessLayerAndHelper(string FilePath, string DatabaseName )
        {
            StringBuilder ContentOfFile = new StringBuilder();
           
                for (int i = 0; i < _bussiness.Tables.Count; i++)
                {
                    _bussiness.FillParamtersOfDataBase(DatabaseName, _bussiness.Tables[i]);
                    string FileName = $"clsData{_bussiness.Tables[i].Substring(0, _bussiness.Tables[i].Length - 1)}.cs";
                    ContentOfFile.Append($"{_bussiness.GenerateDataAcesss(_bussiness.Tables[i])}");
                    string newFilePath = ($"{FilePath}\\{FileName}");
                    File.WriteAllText(newFilePath, ContentOfFile.ToString());
                    ContentOfFile.Clear();

                }
            _GenerateAllFilesOfDataAccessHelper(FilePath);

        }

    }
}
