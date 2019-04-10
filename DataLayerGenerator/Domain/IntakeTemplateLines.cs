using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblIntakeTemplateLines.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class IntakeTemplateLines 
    {
        public long Index { get; set; }
        public decimal LineNo { get; set; }
        public string Parameter { get; set; }
        public int? Category { get; set; }
        public string Format { get; set; }
        public string Default { get; set; }
        public int? WriteProtect { get; set; }
    }
}      
