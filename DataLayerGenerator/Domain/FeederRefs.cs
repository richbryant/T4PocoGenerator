using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblFeederRefs.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class FeederRefs 
    {
        public long MatIndex { get; set; }
        public int Area { get; set; }
        public int Vessel { get; set; }
        public int? Output { get; set; }
        public string FeederName { get; set; }
        public int? Interlock { get; set; }
    }
}      
