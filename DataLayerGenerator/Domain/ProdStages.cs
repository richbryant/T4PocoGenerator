using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblProdStages.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ProdStages 
    {
        public long ScheduleID { get; set; }
        public int BatchNo { get; set; }
        public int Area { get; set; }
        public int StationID { get; set; }
        public int StageID { get; set; }
        public short? State { get; set; }
        public DateTime? DateTime { get; set; }
    }
}      
