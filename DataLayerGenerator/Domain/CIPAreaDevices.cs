using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPAreaDevices.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPAreaDevices 
    {
        public long Index { get; set; }
        public long CIPArea { get; set; }
        public long DeviceID { get; set; }
        public long Attributes { get; set; }
        public string Comment { get; set; }
        public long? DeviceReference { get; set; }
        public bool? Monitored { get; set; }
        public int? State { get; set; }
    }
}      
