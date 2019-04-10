using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblProdStagesRequests.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ProdStagesRequests 
    {
        public long ScheduleID { get; set; }
        public int BatchNo { get; set; }
        public int StageID { get; set; }
        public int Area { get; set; }
        public int StationId { get; set; }
        public DateTime? DateTime { get; set; }
        public int? State { get; set; }
        public string StageData { get; set; }
        public int? Vessel { get; set; }
    }
}      
