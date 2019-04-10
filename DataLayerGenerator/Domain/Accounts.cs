using System;
namespace Practicon.ProTrace.Datalayer
{
    /// <summary>
    /// Represents a tblAccounts.
    /// NOTE: This class is generated from a T4 template.
    /// </summary>
    public class Accounts 
    {
        public long Index { get; set; }
        public string Forename { get; set; }
        public string Middlename { get; set; }
        public string Surname { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public short? Salutation { get; set; }
        public short? State { get; set; }
        public DateTime? DateCreated { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public long? ModifiedBy { get; set; }
        public string Comment { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public short? ContactGroup { get; set; }
    }
}      
