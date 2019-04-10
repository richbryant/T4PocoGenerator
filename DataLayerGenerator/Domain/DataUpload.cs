using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblDataUpload.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class DataUpload 
    {
        public long TransID { get; set; }
        public string TransCode { get; set; }
        public int? Retry { get; set; }
        public long? ProdIndex { get; set; }
        public string ProdCode { get; set; }
        public int? StationID { get; set; }
        public int? BatchNo { get; set; }
        public int? VesselNo { get; set; }
        public decimal? LineNo { get; set; }
        public int? Process { get; set; }
        public string RecipeCode { get; set; }
        public string RecipeDesc { get; set; }
        public string MatCode { get; set; }
        public string HUCode { get; set; }
        public decimal? Value { get; set; }
        public string Units { get; set; }
        public DateTime? DateTimeSent { get; set; }
        public DateTime? DateTimeReceived { get; set; }
        public int? ResponseStatus { get; set; }
        public string ResponseText { get; set; }
        public string Operator { get; set; }
        public string BatchCode { get; set; }
    }
}      
