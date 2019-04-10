using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblINIFiles.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class INIFiles 
    {
        public long? ConfigID { get; set; }
        public long Index { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public int? State { get; set; }
        public string Folder { get; set; }
        public int? Type { get; set; }
        public long? TemplateID { get; set; }
        public string XMLData { get; set; }
        public string Filename { get; set; }
        public int? SystemUse { get; set; }
    }
}      
