using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPAreasLocking.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPAreasLocking 
    {
        public long Index { get; set; }
        public long CIPArea { get; set; }
        public bool AreaOpen { get; set; }
        public string AreaOpenUser { get; set; }
    }
}      
