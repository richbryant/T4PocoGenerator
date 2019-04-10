using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPGlobalInstructions.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPGlobalInstructions 
    {
        public long Index { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public int? State { get; set; }
        public int? InstructionType { get; set; }
        public int? PLCID { get; set; }
    }
}      
