using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblIntakeTemplateHead.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class IntakeTemplateHead 
    {
        public long Index { get; set; }
        public int? Area { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string Operator { get; set; }
    }
}      
