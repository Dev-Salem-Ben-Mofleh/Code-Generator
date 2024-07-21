using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bussinse
{
    public class clsBussinessayer
    {
        clsBussiness _bussiness;

        public clsBussinessayer(clsBussiness bussiness)
        {
            _bussiness = bussiness;


        }
        private string _GetPrimairyKay()
        {
            return _bussiness.PrimeryKeys;
        }
        


        private StringBuilder _GetAllParamtersForDecleared(bool WithPrimaryKeyOrNot)
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
                AllParamters.Append($"public {clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter}{{ get; set; }}\r\n");
 
                }
                else
                {
                    if (clsHleperMethods.IsString(DatatypeAndNull[0]))
                    {
                        AllParamters.Append($"public {clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter}{{ get; set; }}\r\n");
                    }
                    else
                    {
                        if (DatatypeAndNull[1] == "NO")
                            AllParamters.Append($"public {clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter}{{ get; set; }}\r\n");
                        else
                            AllParamters.Append($"public {clsHleperMethods.GitDataType(DatatypeAndNull[0])}? {Paramter}{{ get; set; }}\r\n");


                    }
                }
            }



            return (AllParamters);
        }
        private StringBuilder _FillAllParamtersForConstructor1(bool WithPrimaryKeyOrNot)
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
                    AllParamters.Append(
                                        $"this.{Paramter}= {clsHleperMethods.GitDefaultValue(DatatypeAndNull[0])};\r\n");
                else
                {
                    AllParamters.Append(
                                        $"this.{Paramter} = null;\r\n");
                }
            }


            return AllParamters;
        }
        private StringBuilder _FillAllParamtersForDeclearFindMethod(bool WithPrimaryKeyOrNot)
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
                    AllParamters.Append($"{clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter}= {clsHleperMethods.GitDefaultValue(DatatypeAndNull[0])};\r\n");
                }
                else
                {
                    if (clsHleperMethods.IsString(DatatypeAndNull[0]))
                    {
                        if (DatatypeAndNull[1] == "NO")
                            AllParamters.Append($"{clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter}= {clsHleperMethods.GitDefaultValue(DatatypeAndNull[0])};\r\n");
                        else
                            AllParamters.Append($"{clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter}= null;\r\n");

                    }
                    else
                    {
                        if (DatatypeAndNull[1] == "NO")
                            AllParamters.Append($"{clsHleperMethods.GitDataType(DatatypeAndNull[0])} {Paramter}= {clsHleperMethods.GitDefaultValue(DatatypeAndNull[0])};\r\n");
                        else
                            AllParamters.Append($"{clsHleperMethods.GitDataType(DatatypeAndNull[0])}? {Paramter}= {clsHleperMethods.GitDefaultValue(DatatypeAndNull[0])};\r\n");


                    }

                }
            }


            return AllParamters;
        }

        private StringBuilder _FillAllParamtersForMethods(bool WithPrimaryKeyOrNot)
        {
            StringBuilder AllParamters = new StringBuilder();
            string Paramter = "";

            foreach (KeyValuePair<string, string> Parametrs in _bussiness.Parametrs)
            {
                Paramter = Parametrs.Key;
                if (WithPrimaryKeyOrNot)
                {
                    if (_GetPrimairyKay() == Paramter)
                    {
                        WithPrimaryKeyOrNot = false;
                        continue;
                    }
                }
                
                    AllParamters.Append(
                                        $"this.{Paramter},");
            }


            return AllParamters.Remove(AllParamters.Length - 1, 1);
        }
        private StringBuilder _FillAllParamtersForContructorOfFind(bool WithPrimaryKeyOrNot)
        {
            StringBuilder AllParamters = new StringBuilder();
            string Paramter = "";

            foreach (KeyValuePair<string, string> Parametrs in _bussiness.Parametrs)
            {
                Paramter = Parametrs.Key;
                if (WithPrimaryKeyOrNot)
                {
                    if (_GetPrimairyKay() == Paramter)
                    {
                        WithPrimaryKeyOrNot = false;
                        continue;
                    }
                }
                AllParamters.Append(
                                    $"{Paramter},");
            }


            return AllParamters.Remove(AllParamters.Length - 1, 1);
        }

        private StringBuilder _GetAllParamtersForFind(bool WithPrimaryKeyOrNot)
        {
            StringBuilder AllParamters = new StringBuilder();
            string Paramter = "";

            foreach (KeyValuePair<string, string> Parametrs in _bussiness.Parametrs)
            {

                Paramter = Parametrs.Key;
                if (WithPrimaryKeyOrNot)
                {
                    if (_GetPrimairyKay() == Paramter)
                    {
                        WithPrimaryKeyOrNot = false;
                        continue;
                    }
                }
                AllParamters.Append($"ref {Paramter},");
            }



            return (AllParamters.Remove(AllParamters.Length - 1, 1));
        }

        private StringBuilder _GetAllParamtersForAddAndUpdate(bool WithPrimaryKeyOrNot)
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
        private StringBuilder _FillAllParamtersForConstructor2(bool WithPrimaryKeyOrNot)
        {

            StringBuilder AllParamters = new StringBuilder();
            string Paramter = "";

            foreach (KeyValuePair<string, string> Parametrs in _bussiness.Parametrs)
            {

                Paramter = Parametrs.Key;
                if (WithPrimaryKeyOrNot)
                {
                    if (_GetPrimairyKay() == Paramter)
                    {
                        WithPrimaryKeyOrNot = false;
                        continue;
                    }
                }
                
                AllParamters.Append(
                                      $"this.{Paramter} = {Paramter};\r\n");



            }
            return AllParamters;
        }

        private string _GetNameSpaceBussiness()
        {
           return (_bussiness.NameSpaceBussiness == "" ? "InstituteBussiness" : _bussiness.NameSpaceBussiness);
        }

        private string _GetNameSpaceDataAccess()
        {
            return (_bussiness.NameSpaceBussiness == "" ? "InstituteDataAccess" : _bussiness.NameSpaceDataAccess);
        }

        public StringBuilder GenerateBussinessLayer(string TableName)
        {
            string TableNameForOne = TableName.Substring(0, TableName.Length - 1);
            string PrimeryKey = _GetPrimairyKay();
            StringBuilder BussinessLayer = new StringBuilder();



                BussinessLayer.Append($"using System;\r\n" +
                    $"using System.Data;\r\n" +
                    $"using {_GetNameSpaceDataAccess()};\r\n\r\n" +
                    $"namespace {_GetNameSpaceBussiness()}\r\n" +
                    $"{{\r\n" +
                    $"    public class cls{TableNameForOne}\r\n" +
                    $"    {{\r\n" +
                    $"        public enum enMode {{ AddNew = 0, Update = 1 }};\r\n" +
                    $"        public enMode Mode = enMode.AddNew;\r\n\r\n\r\n" +
                    $"        public int? {PrimeryKey}{{ get; set; }}\r\n" +
                    $"           {_GetAllParamtersForDecleared(true)}" +
                    $"        public cls{TableNameForOne}()\r\n" +
                    $"        {{\r\n" +
                    $"            this.{PrimeryKey} = null;\r\n" +
                    $"        {_FillAllParamtersForConstructor1(true)} " +
                    $"            Mode = enMode.AddNew;\r\n" +
                    $"        }}\r\n\r\n" +
                    $"        public cls{TableNameForOne}(int? {PrimeryKey},{_GetAllParamtersForAddAndUpdate(true)})\r\n" +
                    $"        {{\r\n" +
                    $"            this.{PrimeryKey} = {PrimeryKey};\r\n " +
                    $"           {_FillAllParamtersForConstructor2(true)}" +
                    $"            Mode = enMode.Update;\r\n" +
                    $"        }}\r\n\r\n" +
                    $"        private bool _AddNew{TableNameForOne}()\r\n" +
                    $"        {{\r\n" +
                    $"            this.{PrimeryKey} = cls{TableNameForOne}Data.AddNew{TableNameForOne}({_FillAllParamtersForMethods(true)});\r\n\r\n" +
                    $"            return (this.{PrimeryKey}.HasValue);\r\n" +
                    $"        }}\r\n\r\n" +
                    $"        private bool _Update{TableNameForOne}()\r\n" +
                    $"        {{\r\n" +
                    $"            return cls{TableNameForOne}Data.Update{TableNameForOne}(this.{PrimeryKey},{_FillAllParamtersForMethods(true)});\r\n" +
                    $"        }}\r\n\r\n" +
                    $"        public bool Save()\r\n" +
                    $"        {{\r\n" +
                    $"            switch (Mode)\r\n" +
                    $"            {{\r\n" +
                    $"                case enMode.AddNew:\r\n" +
                    $"                    if (_AddNew{TableNameForOne}())\r\n" +
                    $"                    {{\r\n" +
                    $"                        Mode = enMode.Update;\r\n" +
                    $"                        return true;\r\n" +
                    $"                    }}\r\n" +
                    $"                    else\r\n" +
                    $"                    {{\r\n" +
                    $"                        return false;\r\n" +
                    $"                    }}\r\n\r\n" +
                    $"                case enMode.Update:\r\n" +
                    $"                    return _Update{TableNameForOne}();\r\n" +
                    $"            }}\r\n\r\n" +
                    $"            return false;\r\n" +
                    $"        }}\r\n\r\n" +
                    $"        public static cls{TableNameForOne} Find(int? {PrimeryKey})\r\n" +
                    $"        {{\r\n" +
                    $"            {_FillAllParamtersForDeclearFindMethod(true)}" +
                    $"            bool IsFound = cls{TableNameForOne}Data.Get{TableNameForOne}InfoByID({PrimeryKey},{_GetAllParamtersForFind(true)});\r\n\r\n" +
                    $"            if (IsFound)\r\n" +
                    $"            {{\r\n" +
                    $"                return new cls{TableNameForOne}({PrimeryKey},{_FillAllParamtersForContructorOfFind(true)});\r\n" +
                    $"            }}\r\n" +
                    $"            else\r\n" +
                    $"            {{\r\n" +
                    $"                return null;\r\n" +
                    $"            }}\r\n" +
                    $"        }}\r\n\r\n" +
                    $"        public static bool Delete{TableNameForOne}(int? {PrimeryKey})\r\n" +
                    $"        {{\r\n" +
                    $"            return cls{TableNameForOne}Data.Delete{TableNameForOne}({PrimeryKey});\r\n" +
                    $"        }}\r\n\r\n" +
                    $"    \r\n" +
                    $"        public static bool Does{TableNameForOne}Exist(int? {PrimeryKey})\r\n" +
                    $"        {{\r\n" +
                    $"            return cls{TableNameForOne}Data.Does{TableNameForOne}Exist({PrimeryKey});\r\n" +
                    $"        }}\r\n\r\n" +
                    $"        public static DataTable GetAll{TableName}()\r\n" +
                    $"        {{\r\n" +
                    $"            return cls{TableNameForOne}Data.GetAll{TableName}();\r\n" +
                    $"        }}\r\n\r\n\r\n" +
                    $"    }}\r\n}}\r\n"

                    );
            return BussinessLayer;


        }

    }

}