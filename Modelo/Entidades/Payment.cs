using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Payment
    {
        public int paymentId { get; set; }
       
        public int staff_id { get; set; }        
        public float amount { get; set; }
        public DateTime payment_date { get; set; }

        public Customer Customer { get; set; }
        public int customerId { get; set; }

        public Rental Rental { get; set; }
        public int rental_id { get; set; }
    }
}
