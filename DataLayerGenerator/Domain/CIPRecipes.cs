using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPRecipes.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPRecipes 
    {
        public long Index { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long? CIPArea { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public int? RevisionActive { get; set; }
        public bool Development { get; set; }
        public bool? Archive { get; set; }
        public string Comment { get; set; }
        public bool? Reserved { get; set; }
        public int? State { get; set; }
        public DateTime? Started { get; set; }
        public DateTime? Scheduled { get; set; }
        public DateTime? Finished { get; set; }
        public string ProductionCode { get; set; }
        public long? OriginalRecipeID { get; set; }
        public long? IndexID { get; set; }
        public bool? AllowWhenSoiled { get; set; }
        public bool? AllowWhenPartClean { get; set; }
        public bool? AllowWhenClean { get; set; }
    }
}      
