using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblSMSConfig.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class SMSConfig 
    {
        public short Index { get; set; }
        public string Provider { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string URL { get; set; }
        public string Comment { get; set; }
        public short? State { get; set; }
        public bool Enabled { get; set; }
    }
}      
