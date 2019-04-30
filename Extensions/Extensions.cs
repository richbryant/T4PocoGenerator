using System.Collections.Generic;
using System.Linq;
using Humanizer;

namespace Extensions
{
    public static class Extensions
    {
        public static string Clean(this string s)
        {
            s = s.Replace("tbl", "");
            s = s.Replace("CIP", "Cip");
            s = s.Replace("OPC", "Opc");
            s = s.Replace("fldId", "Index");
            s = s.Replace("fldIndex", "Id");
            s = s.Replace("fld", "");
            s = s.Replace("ID", "Id");

            var result = s.Singularize();
            return !string.IsNullOrEmpty(result) ? result : s;
        }
    }
}
