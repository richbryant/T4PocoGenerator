using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblLocking.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Locking 
    {
        public long Index { get; set; }
        public string Tablename { get; set; }
        public string LockingField { get; set; }
        public string Value { get; set; }
        public DateTime? DateTime { get; set; }
        public string Location { get; set; }
        public string Username { get; set; }
    }
}      
