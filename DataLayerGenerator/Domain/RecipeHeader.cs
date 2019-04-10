using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblRecipeHeader.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class RecipeHeader 
    {
        public long Index { get; set; }
        public string Code { get; set; }
        public int? Area { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string Operator { get; set; }
        public int? RevisionActive { get; set; }
        public string RevisionText { get; set; }
        public string AreaView { get; set; }
        public int? CIP { get; set; }
        public int Development { get; set; }
        public int? QA { get; set; }
        public int? Archive { get; set; }
    }
}      
