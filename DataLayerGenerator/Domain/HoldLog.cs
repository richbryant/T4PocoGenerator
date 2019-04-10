using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblHoldLog.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class HoldLog 
    {
        public DateTime? DateTime { get; set; }
        public string ProdCode { get; set; }
        public string RecipeCode { get; set; }
        public int? EnumValue { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public string Format { get; set; }
        public string ValueEnum { get; set; }
    }
}      
