using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblVehicle.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Vehicle 
    {
        public long Index { get; set; }
        public string Vehicle { get; set; }
        public decimal? Weight { get; set; }
        public int? Deleted { get; set; }
    }
}      
