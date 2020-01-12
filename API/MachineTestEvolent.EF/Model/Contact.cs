using System;
using System.Collections.Generic;
using System.Text;

namespace MachineTestEvolent.EF.Model
{
   public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public bool Status { get; set; }
    }
}
