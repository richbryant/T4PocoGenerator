using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblIntakeHead.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class IntakeHead 
    {
        public long Index { get; set; }
        public DateTime? DateTime { get; set; }
        public int? Area { get; set; }
        public string MatCode { get; set; }
        public string MatDesc { get; set; }
        public string BatchCode { get; set; }
        public string TemplateName { get; set; }
        public string TemplateDesc { get; set; }
        public string Operator { get; set; }
    }
}      
