using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblBatchCodes.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class BatchCodes 
    {
        public long MatIndex { get; set; }
        public long BatchIndex { get; set; }
        public string BatchCode { get; set; }
        public decimal? BatchUsage { get; set; }
        public decimal? Stock { get; set; }
        public string UseByDate { get; set; }
        public int? Quarantine { get; set; }
        public string HUCode { get; set; }
        public DateTime? LastModified { get; set; }
    }
}      
