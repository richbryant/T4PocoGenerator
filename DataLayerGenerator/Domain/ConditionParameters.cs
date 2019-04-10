using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblConditionParameters.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class ConditionParameters 
    {
        public int? ConditionID { get; set; }
        public int? IOID { get; set; }
        public short? Operator { get; set; }
        public string Value { get; set; }
        public short? NextOperator { get; set; }
    }
}      
