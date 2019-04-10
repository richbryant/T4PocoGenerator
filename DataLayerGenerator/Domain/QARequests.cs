using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblQARequests.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class QARequests 
    {
        public long Index { get; set; }
        public long ProdIndex { get; set; }
        public int Area { get; set; }
        public long? QAProdIndex { get; set; }
        public long? QARecipeID { get; set; }
        public int? State { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public int? BatchNo { get; set; }
        public bool? AutoAccept { get; set; }
        public int? QAID { get; set; }
        public int? StationID { get; set; }
        public int? Vessel { get; set; }
        public int? LineNumber { get; set; }
        public int? RepeatCount { get; set; }
        public string Comment { get; set; }
        public string QARequestID { get; set; }
        public int? BookedInState { get; set; }
        public long? UserID { get; set; }
        public string QARecipeCode { get; set; }
        public string QARecipeDescription { get; set; }
        public string ProdCode_Archive { get; set; }
        public string RecipeCode_Archive { get; set; }
        public string RecipeDescription_Archive { get; set; }
        public string QAProdCode { get; set; }
    }
}      
