using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblMimicDataLogged.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class MimicDataLogged 
    {
        public long? SnapShotID { get; set; }
        public DateTime DateTime { get; set; }
        public int MimicID { get; set; }
        public long OPCTagID { get; set; }
        public string Value { get; set; }
    }
}      
