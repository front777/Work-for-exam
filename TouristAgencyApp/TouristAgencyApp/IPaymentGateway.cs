using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgencyApp
{
    internal interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }
}
