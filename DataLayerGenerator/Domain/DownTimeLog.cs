using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblDownTimeLog.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class DownTimeLog 
    {
        public DateTime? DateTime { get; set; }
        public string Area { get; set; }
        public string Reason { get; set; }
        public string Comment { get; set; }
        public string Operator { get; set; }
        public int? Status { get; set; }
    }
}      
