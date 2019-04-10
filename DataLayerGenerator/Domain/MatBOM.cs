using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblMatBOM.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class MatBOM 
    {
        public string OrderNo { get; set; }
        public int LineNo { get; set; }
        public string MatCode { get; set; }
        public string MatDesc { get; set; }
        public decimal? Target { get; set; }
        public int UOM { get; set; }
    }
}      
