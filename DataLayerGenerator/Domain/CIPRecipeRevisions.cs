using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPRecipeRevisions.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPRecipeRevisions 
    {
        public long Index { get; set; }
        public long RecipeID { get; set; }
        public int RevisionNo { get; set; }
        public string OperatorName { get; set; }
        public string Text { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public long? AverageExecutionTime { get; set; }
        public long? QuickestExecutionTime { get; set; }
        public bool? AllowWhenSoiled { get; set; }
        public bool? AllowWhenPartClean { get; set; }
        public bool? AllowWhenClean { get; set; }
    }
}      
