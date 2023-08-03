using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgencyApp
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }
   
        public string PaymentInformation { get; set; }

        public string Price { get; set; }
        public List<Booking> BookingHistory { get; set; }

        public Customer()
        {
            BookingHistory = new List<Booking>();
        }
    }
}
