using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblDataLogged.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class DataLogged 
    {
        public DateTime? DateTime { get; set; }
        public int? ScheduleID { get; set; }
        public string RecipeCode { get; set; }
        public string ProdCode { get; set; }
        public string Data { get; set; }
        public long? OPCTag { get; set; }
        public string Status { get; set; }
        public string Mode { get; set; }
        public string TagName { get; set; }
        public long? BatchNumber { get; set; }
    }
}      
