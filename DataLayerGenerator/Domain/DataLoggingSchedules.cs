using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblDataLoggingSchedules.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class DataLoggingSchedules 
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public short? State { get; set; }
        public DateTime? LastRun { get; set; }
        public string ProdCodeTag { get; set; }
        public string RecipeCodeTag { get; set; }
        public int? Interval { get; set; }
        public string StatusTag { get; set; }
        public int? StatusID { get; set; }
        public string Status2Tag { get; set; }
        public int? Status2ID { get; set; }
        public bool? ProdCodeReq { get; set; }
        public long BatchNumber { get; set; }
    }
}      
