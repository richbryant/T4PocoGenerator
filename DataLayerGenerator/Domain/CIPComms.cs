using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPComms.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPComms 
    {
        public long Index { get; set; }
        public long? CIPArea { get; set; }
        public long? RecipeID { get; set; }
        public long? CycleID { get; set; }
        public long? StageID { get; set; }
        public long? InstructionID { get; set; }
        public int? Type { get; set; }
        public string Message { get; set; }
        public DateTime? Date { get; set; }
        public int? InstructionProcess { get; set; }
        public int? InstructionError { get; set; }
        public int? StageError { get; set; }
        public int? CycleError { get; set; }
        public int? RecipeError { get; set; }
        public int? RecipeStatus { get; set; }
        public int? CycleStatus { get; set; }
        public int? StageStatus { get; set; }
        public string ExceptionMessage { get; set; }
        public string ExceptionName { get; set; }
    }
}      
