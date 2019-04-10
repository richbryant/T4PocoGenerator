using System.Collections.Generic;
using System.Linq;

namespace DataLayerGenerator
{
    public static class Tidy
    {
        private static readonly Dictionary<string, string> Replacements = new Dictionary<string, string>()
        {
            {"tbl", ""},
            {"fld", ""},
            {"CIP", "Cip"},
            {"OPC ", "Opc"},
        };

        public static string Clean(string s)
        {
            return Replacements.Aggregate(s, (current, replacement) => current.Replace(replacement.Key, replacement.Value));
        }
    }
}
