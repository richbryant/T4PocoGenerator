using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCommsLogs.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CommsLogs 
    {
        public DateTime? DateTime { get; set; }
        public long? TimeTaken { get; set; }
        public int? StationID { get; set; }
        public int? TCPCommand { get; set; }
        public string ProdCode { get; set; }
        public string RecipeCode { get; set; }
        public string RecipeDesc { get; set; }
        public int? BatchNo { get; set; }
        public int? VesselNo { get; set; }
        public string ClientData { get; set; }
        public int? ServerResponse { get; set; }
        public string ServerError { get; set; }
    }
}      
