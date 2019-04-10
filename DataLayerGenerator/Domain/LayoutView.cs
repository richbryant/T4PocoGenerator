using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblLayoutView.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class LayoutView 
    {
        public int Index { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public short? State { get; set; }
        public int? LayoutID { get; set; }
        public int? LayoutIOID { get; set; }
        public int? Area { get; set; }
    }
}      
