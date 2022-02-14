using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieRentalSoftware
{
    class CustomerCard
    {
        public int CardNumber { get; set; }
        public int SecurityCode { get; set; }
        public DateTime ExpieryDate { get; set; }
        public string NameOnCard { get; set; }
        public int SortCode { get; set; }
    }
}
