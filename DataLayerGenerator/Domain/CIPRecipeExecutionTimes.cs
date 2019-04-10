using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPRecipeExecutionTimes.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPRecipeExecutionTimes 
    {
        public long Index { get; set; }
        public long OriginalRecipeID { get; set; }
        public DateTime DateCreated { get; set; }
        public long ExecutionTime { get; set; }
    }
}      
