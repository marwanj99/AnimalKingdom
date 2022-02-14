using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieRentalSoftware
{
    class Customer
    {
        public string Fname { get; private set; }
        public string Lname { get; private set; }
        public string Email { get; private set;}
        public int CardNumber { get; set; }
        public int SecurityCode { get; set; }
        public string NameOnCard { get; set; }
    }
}
