using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussinse
{
    public static class clsHleperMethods
    {
        public static string GitDataType(string DataType)
        {
            switch (DataType)
            {
                case "datetimeoffset":
                    return "DateTimeOffset";
                case "variant":
                case "udt":
                case "structured":
                    return "object";
                case "tinyint":
                    return "byte";
                case "smallint":
                    return "short?";
                case "bigInt":
                    return "long?";
                case "binary":
                case "image":
                case "varvinary":
                case "timestamp":
                    return "byte[]";
                case "bit":
                    return "bool";
                case "datetime":
                case "datetime2":
                case "date":
                case "smalldatetime":
                    return "DateTime";
                case "time":
                    return "TimeSpan";
                case "char":
                case "nchar":
                case "ntext":
                case "nvarchar":
                case "varchar":
                case "xml":
                case "text":
                    return "string";
                case "decimal":
                case "smallmoney":
                case "money":
                case "real":
                    return "decimal";
                case "float":
                    return "double";
                case "int":
                    return "int?";
                case "uniqueIdentifier":
                    return "Guid";


            }
            return "No";
        }
        public static string GitDefaultValue(string DataType)
        {
            switch (DataType)
            {
                case "int":
                case "bigInt":
                case "SmallInt":
                    return "null"; // Default for integer types

                case "float":
                    return "-1F;"; // Default for float

                case "decimal":
                case "money":
                case "smallmoney":
                    return "-1M;"; // Default for decimal types

                case "tinyint":
                    return "0;"; // Default for tinyint (byte)

                case "varchar":
                case "nvarchar":
                case "text":
                    return "string.Empty;"; // Default for variable-length strings

                case "char":
                case "nchar":
                    return "' ';"; // Default for fixed-length strings

                case "datetime":
                case "date":
                case "smallDateTime":
                case "datetime2":
                    return "DateTime.Now;"; // Default for DateTime

                case "time":
                    return "TimeSpan.Zero;"; // Default for TimeSpan

                case "bit":
                    return "false;"; // Default for boolean

                case "uniqueidentifier":
                    return "Guid.Empty;"; // Default for GUIDs

                case "binary":
                case "barbinary":
                case "timestamp":
                case "Image":
                    return "new byte[0];"; // Default for binary data

                case "xml":
                    return "string.Empty;"; // Default for XML data

                case "Real":
                    return "-1.0F;"; // Default for Real (single-precision float)

                case "variant":
                case "udt":
                case "structured":
                    return "null;"; // Default for Variant, UDT, Structured

                case "datetimeoffset":
                    return "DateTimeOffset.Now;"; // Default for DateTime with timezone

                default:
                    return "null;"; // Default for any other types
            }
        }
        public static bool IsString(string DataType)=>
            (DataType == "nvarchar" || DataType == "varchar" || DataType == "ntext" || DataType == "text" || DataType == "xml");
        public static bool IsInt(string DataType) =>(DataType == "long" || DataType == "int");


    }
}
