using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblEmailConfig.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class EmailConfig 
    {
        public short? Index { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Port { get; set; }
        public string Signature { get; set; }
        public short? SecurityType { get; set; }
        public short? State { get; set; }
        public bool? SSL { get; set; }
        public bool Enabled { get; set; }
        public short Type { get; set; }
        public string ExchangeServer { get; set; }
    }
}      
