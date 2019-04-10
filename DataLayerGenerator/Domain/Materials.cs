using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblMaterials.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Materials 
    {
        public long Index { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal? Usage { get; set; }
        public DateTime? DateZero { get; set; }
        public decimal? SG { get; set; }
        public decimal? BagWeight { get; set; }
        public string Colour { get; set; }
        public long? PromptIndex { get; set; }
        public int? Verification { get; set; }
        public int UOM { get; set; }
    }
}      
