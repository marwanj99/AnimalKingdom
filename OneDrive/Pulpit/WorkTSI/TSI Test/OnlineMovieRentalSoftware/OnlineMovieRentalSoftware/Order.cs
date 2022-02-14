using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMovieRentalSoftware
{
    class Order
    {
        ////////Attributes///////
        public int OrderNo { get; set; }
        public string CustomerFname { get; set; }
        public string CustomerLname { get; private set; }
        public string MovieTitle { get; set; }
        public DateTime DateBorrowede { get; private set; }
        public int RentalPeriod { get; private set; }



        ////////Constructors///////

        ////////Methods///////////
        public int CreateOrderNo() { return OrderNo; }
    }
}
