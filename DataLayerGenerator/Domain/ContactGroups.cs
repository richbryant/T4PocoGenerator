using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblContactGroups.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ContactGroups 
    {
        public short Index { get; set; }
        public string Name { get; set; }
        public long CreatedBy { get; set; }
        public short State { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
    }
}      
