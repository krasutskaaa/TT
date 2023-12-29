using ParselAndDelivery.vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParselAndDelivery.delivery
{
    public class Delivery
    {
        public string Sender { get; set; }

        public string Recipient { get; set; }

        public Car Car {  get; set;  }
    }
}