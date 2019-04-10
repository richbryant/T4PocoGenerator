using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblVehicleCodes.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class VehicleCodes 
    {
        public long VehicleID { get; set; }
        public long? VehicleIndex { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateServiceStart { get; set; }
        public DateTime? DateServiceExpires { get; set; }
        public int? Obsolete { get; set; }
    }
}      
