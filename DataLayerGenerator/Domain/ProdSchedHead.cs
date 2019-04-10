using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblProdSchedHead.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ProdSchedHead 
    {
        public long Index { get; set; }
        public string ProdCode { get; set; }
        public long? RecipeIndex { get; set; }
        public int? NoBatches { get; set; }
        public int? Set { get; set; }
        public decimal? BatchSize { get; set; }
        public int? Mode { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Operator { get; set; }
        public decimal? ForceSize { get; set; }
        public DateTime? PrintedDate { get; set; }
        public int? QA { get; set; }
    }
}      
