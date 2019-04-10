using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPGlobalDevices.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPGlobalDevices 
    {
        public long Index { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public int? State { get; set; }
        public long? TypeID { get; set; }
        public bool? Pulseable { get; set; }
        public bool? FixedSpeed { get; set; }
    }
}      
