using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblMimicDataProviderConfig.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class MimicDataProviderConfig 
    {
        public int? Index { get; set; }
        public string ServiceAddress { get; set; }
        public int? MaxCaches { get; set; }
        public int? CacheUpdateRate { get; set; }
        public int? CacheLifeTime { get; set; }
        public int? SnapShotInterval { get; set; }
        public int? MaxCacheEvents { get; set; }
        public int? RefreshInterval { get; set; }
        public string ServiceAddressTCP { get; set; }
        public DateTime? EarliestDate { get; set; }
    }
}      
