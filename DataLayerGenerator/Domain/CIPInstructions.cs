using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPInstructions.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPInstructions 
    {
        public long Index { get; set; }
        public long? CIPArea { get; set; }
        public long? InstructionID { get; set; }
        public string Comment { get; set; }
        public int? State { get; set; }
        public long? DeviceID { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }
        public string Param4 { get; set; }
        public string Param5 { get; set; }
        public string Param6 { get; set; }
        public string Param7 { get; set; }
        public string Param8 { get; set; }
        public string Param9 { get; set; }
        public string Param10 { get; set; }
        public long? StageID { get; set; }
        public DateTime? Started { get; set; }
        public DateTime? Finished { get; set; }
        public int? DataType { get; set; }
        public int? RepeatCount { get; set; }
        public long? IndexID { get; set; }
    }
}      
