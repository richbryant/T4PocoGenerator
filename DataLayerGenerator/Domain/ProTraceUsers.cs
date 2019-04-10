using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblProTraceUsers.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ProTraceUsers 
    {
        public int Index { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public short? State { get; set; }
        public long? AccountNumber { get; set; }
        public int? UserGroup { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
    }
}      
