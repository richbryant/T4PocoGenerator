using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblLicenceManagerConfig.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class LicenceManagerConfig 
    {
        public short? Index { get; set; }
        public string ServiceAddress { get; set; }
        public string WebViewAddress { get; set; }
        public int? UpdateInterval { get; set; }
        public int? ConfigRefresh { get; set; }
        public int? LicenceRefresh { get; set; }
    }
}      
