using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgencyApp
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }

       
       
        public string Status { get; set; }

        public void UpdateBookingStatus(string newStatus)
        {
            Status = newStatus;
        }
    }
}
