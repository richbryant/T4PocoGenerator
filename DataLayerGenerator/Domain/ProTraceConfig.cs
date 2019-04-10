using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblProTraceConfig.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ProTraceConfig 
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public short? State { get; set; }
        public string AreasXML { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? DefaultArea { get; set; }
        public string Repository { get; set; }
        public string PowerUser { get; set; }
        public string Token { get; set; }
    }
}      
