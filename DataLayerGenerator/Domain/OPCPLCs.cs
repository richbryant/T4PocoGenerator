using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblOPCPLCs.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class OPCPLCs 
    {
        public int OPCServer { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public string Device { get; set; }
        public string Model { get; set; }
        public string Comment { get; set; }
        public int? State { get; set; }
    }
}      
