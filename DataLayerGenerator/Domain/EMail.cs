using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblEMail.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class EMail 
    {
        public long Index { get; set; }
        public long AccountIndex { get; set; }
        public string EMailAddress { get; set; }
        public short State { get; set; }
    }
}      
