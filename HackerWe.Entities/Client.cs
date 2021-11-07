using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerWe.Entities
{
    public class Client
    {
        
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => FirstName + " " + LastName;
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Client(string identityNumber, string firstName, string lastName, string email, string phoneNumber)
        {
            IdentityNumber = identityNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        
    }


}
