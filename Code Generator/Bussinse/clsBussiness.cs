using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Bussinse
{
    public class clsBussiness
    {
        public string DatabaseName { get; set; }
        public List<string> Tables { get; set; }
        public SortedDictionary<string, string>Parametrs { get; set; }
        public string PrimeryKeys { get; set; }
        public string NameSpaceDataAccess { get; set; }
        public string NameSpaceBussiness { get; set; }


        public clsBussiness()
        {
            this.DatabaseName = "";
            this.Tables = new List<string>();   
            this.Parametrs=new SortedDictionary<string, string>();
            this.PrimeryKeys = "";
            this.NameSpaceDataAccess = "";
            this.NameSpaceBussiness = "";

        }
        public clsBussiness(string DatabaseName, List< string> Tables,
            SortedDictionary<string, string> Parametrs, string PrimereisKeys,string NameSpaceDataAccess,string NameSpaceBussiness)
        {
            this.DatabaseName = DatabaseName;
            this.Tables = Tables;
            this.Parametrs = Parametrs;
            this.PrimeryKeys= PrimereisKeys;
            this.NameSpaceDataAccess = NameSpaceDataAccess;
            this.NameSpaceBussiness = NameSpaceBussiness;


        }

        public static DataTable GetAll()
        {
            return clsDataAccess.GetAll();
        }

        public  void FillTablesOfDataBase(string DatabaseName)
        {
            List<string> Tables = new List< string>();

                clsDataAccess.FillTablesOfDataBase(DatabaseName, ref Tables);
            this.Tables = Tables;
        }
        public  void FillParamtersOfDataBase(string DatabaseName, string TableName)
        {
            this.Parametrs.Clear();
            this.PrimeryKeys = "";

            SortedDictionary<string, string> Parametrs = new SortedDictionary<string, string>();
            string PrimeryKeys = ""; 
            clsDataAccess.FillParamtersOfDataBase(DatabaseName,TableName, ref Parametrs,ref PrimeryKeys);
            this.Parametrs = Parametrs;
            this.PrimeryKeys = PrimeryKeys;

        }
        public void ExcuteStoredProcedureDircteInSql(string TableName,string DatabaseName)
        {
            clsStoredProcedure StoredProcedure = new clsStoredProcedure(this);

            StoredProcedure.ExcuteStoredProcedureDircteInSql(TableName, DatabaseName);
        }
        public void GenerateAllFilesOfDataAccessLayerAndHelper(string Path,string DatabaseName)
        {
            clsGenerateAllFilesOfDataAccessLayerAndHelper AllFilesOfDataAccessLayerAndHelper = new clsGenerateAllFilesOfDataAccessLayerAndHelper(this);

             AllFilesOfDataAccessLayerAndHelper.GenerateAllFilesOfDataAccessLayerAndHelper(Path, DatabaseName);
        }
        public void GenerateAllFilesOfBussinessLayer(string Path, string DatabaseName)
        {
            clsGenerateAllFilesOfBussinessLayer AllFilesOfBussinessLayer = new clsGenerateAllFilesOfBussinessLayer(this);

            AllFilesOfBussinessLayer.GenerateAllFilesOfBussinessLayer(Path, DatabaseName);
        }
        public void GenerateAllFilesOfStoredProcedure( string DatabaseName)
        {
            clsGenerateAllFilesOfStoredProcedure AllFilesOfStoredProcedure = new clsGenerateAllFilesOfStoredProcedure(this);

            AllFilesOfStoredProcedure.GenerateAllFilesOfStoredProcedure( DatabaseName);
        }
        public void GenerateAppConfig(string Path, string DatabaseName) => clsAppConfig.GenerateAppConfig(Path, DatabaseName);

        public StringBuilder GenerateDataAcesss(string TableName)
        {
            clsDataAccessLayer dataAccessLayer = new clsDataAccessLayer(this);

            return (dataAccessLayer.GenerateDataAcesss(TableName));
        }
        public StringBuilder GenerateBussinessLayer(string TableName)
        {
            clsBussinessayer Bussinessayer = new clsBussinessayer(this);

            return (Bussinessayer.GenerateBussinessLayer(TableName));
        }
        public StringBuilder GenerateStoredProcedure(string TableName)
        {
            clsStoredProcedure StoredProcedure = new clsStoredProcedure(this);

            return (StoredProcedure.GenerateStoredProcedure(TableName));
        }
        public StringBuilder GenerateAcesssSetting(string NameSpaceDataAccess="InstituteDataAccess") => (clsAccessSettings.GenerateAcesssSetting(NameSpaceDataAccess));
        public StringBuilder GenerateErrorLogger(string NameSpaceDataAccess= "InstituteDataAccess") => (clsErrorLogger.GenerateErrorLogger(NameSpaceDataAccess));
        public StringBuilder GenerateDataAcesssHelper(string NameSpaceDataAccess = "InstituteDataAccess") => (clsDataAccessHelper.GenerateDataAcesssHelper(NameSpaceDataAccess));
        public StringBuilder GenerateLogHandler(string NameSpaceDataAccess = "InstituteDataAccess") => (clsLogHandler.GenerateLogHandler(NameSpaceDataAccess));


    }
}
