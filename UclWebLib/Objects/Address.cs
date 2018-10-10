using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UclWebLib.Objects
{
    public class Address
    {
        public string Street { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Address(string _street, int _zip, string _city, string _country)
        {
            Street = _street;
            Zip = _zip;
            City = _city;
            Country = _country;
        }
        public Address() { }
    }
}
