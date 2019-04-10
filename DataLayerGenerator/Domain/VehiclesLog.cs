using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblVehiclesLog.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class VehiclesLog 
    {
        public long Index { get; set; }
        public string VehicleName { get; set; }
        public decimal? VehicleTareWeight { get; set; }
        public long? RecipeIndex { get; set; }
        public int? RecipeArea { get; set; }
        public string RecipeCode { get; set; }
        public string RecipeDesc { get; set; }
        public int? RecipeAutoSeqNo { get; set; }
        public DateTime? DateIssued { get; set; }
        public int? Consumed { get; set; }
        public int? SubContainer { get; set; }
        public string ColourPrimary { get; set; }
        public string ColoursSecondary { get; set; }
    }
}      
