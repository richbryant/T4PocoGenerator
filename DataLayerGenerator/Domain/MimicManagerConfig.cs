using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblMimicManagerConfig.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class MimicManagerConfig 
    {
        public short? Index { get; set; }
        public string ServiceAddress { get; set; }
        public string WebViewAddress { get; set; }
        public string ImagesFolder { get; set; }
        public int? MimicLife { get; set; }
        public string MimicHostPath { get; set; }
        public string MimicHostApp { get; set; }
        public int? UpdateInterval { get; set; }
        public int? MaxInstances { get; set; }
        public int? DeadUserLife { get; set; }
        public int? RefreshConnections { get; set; }
        public int? MaxReturnedItems { get; set; }
        public int SessionLife { get; set; }
    }
}      
