using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydac.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public int PhoneNumber { get; set; }
        public List<Component> Components { get; set; }

        public Customer(string name, string contact, int phoneNumber)
        {
            Name = name;
            Contact = contact;
            PhoneNumber = phoneNumber;
        }
    }
}

