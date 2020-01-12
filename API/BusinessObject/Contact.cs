using System;

namespace BusinessObject
{
    // Contact Object
    public class ContactEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public bool Status { get; set; }
    }
}
