using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPStages.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPStages 
    {
        public long Index { get; set; }
        public long? CIPArea { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public int? State { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public long? OperatorID { get; set; }
        public string OperatorName { get; set; }
        public long? CycleID { get; set; }
        public bool? Reserved { get; set; }
        public DateTime? Started { get; set; }
        public DateTime? Finished { get; set; }
        public int? RepeatCount { get; set; }
        public long? IndexID { get; set; }
    }
}      
