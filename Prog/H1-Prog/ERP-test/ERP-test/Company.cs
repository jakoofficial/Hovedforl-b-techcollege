using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_test
{
    internal enum Currency { DKK, USD }
    internal class Company
    {
        public string CompanyName { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Currency Currency { get; set; }
    }
}
