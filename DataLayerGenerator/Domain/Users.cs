using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblUsers.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Users 
    {
        public long Index { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long? AccessRights { get; set; }
        public string CardID { get; set; }
        public long? AccessRights2 { get; set; }
    }
}      
