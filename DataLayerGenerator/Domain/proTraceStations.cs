using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblproTraceStations.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class proTraceStations 
    {
        public long? ConfigID { get; set; }
        public long Index { get; set; }
        public long? AreaID { get; set; }
        public int StationNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? State { get; set; }
        public string XMLData { get; set; }
        public string Comment { get; set; }
        public string Version { get; set; }
        public long? BuildNumber { get; set; }
    }
}      
