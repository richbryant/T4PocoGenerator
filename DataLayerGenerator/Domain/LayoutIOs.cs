using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblLayoutIOs.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class LayoutIOs 
    {
        public int Index { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public short? State { get; set; }
        public bool? Inuse { get; set; }
        public int Mode { get; set; }
    }
}      
