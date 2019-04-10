using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblOPCServers.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class OPCServers 
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public string Comment { get; set; }
        public int? State { get; set; }
        public int? ServerType { get; set; }
    }
}      
