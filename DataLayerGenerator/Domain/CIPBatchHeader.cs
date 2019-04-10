using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPBatchHeader.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPBatchHeader 
    {
        public long Index { get; set; }
        public long? ProdIndex { get; set; }
        public long? RecipeID { get; set; }
        public int? RevisionNo { get; set; }
        public long? Area { get; set; }
        public string RecipeCode { get; set; }
        public string RecipeDescription { get; set; }
        public int? Status { get; set; }
        public DateTime? DateStarted { get; set; }
        public DateTime? DateFinished { get; set; }
        public string Comment { get; set; }
    }
}      
