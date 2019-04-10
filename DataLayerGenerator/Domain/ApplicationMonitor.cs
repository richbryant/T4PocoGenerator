using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblApplicationMonitor.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ApplicationMonitor 
    {
        public long Index { get; set; }
        public int? ApplicationID { get; set; }
        public string IPAddress { get; set; }
        public DateTime? Date { get; set; }
        public string Username { get; set; }
    }
}      
