using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblVehicles.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Vehicles 
    {
        public long Index { get; set; }
        public string Name { get; set; }
        public decimal? TareWeight { get; set; }
        public decimal? OperatingCapacity { get; set; }
        public long? ImageIndex { get; set; }
        public int? SubContainer { get; set; }
        public string ColourPrimary { get; set; }
        public string ColoursSecondary { get; set; }
    }
}      
