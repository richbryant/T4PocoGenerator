using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblCIPMonitoredInputValues.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class CIPMonitoredInputValues 
    {
        public long RecipeID { get; set; }
        public long MonitoredInputID { get; set; }
        public string Value { get; set; }
        public DateTime DateTime { get; set; }
    }
}      
