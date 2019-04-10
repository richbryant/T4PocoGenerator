using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblFeederInterlocksLines.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class FeederInterlocksLines 
    {
        public long Index { get; set; }
        public long MatIndex { get; set; }
        public int Area { get; set; }
        public int Vessel { get; set; }
        public int? Priority { get; set; }
    }
}      
