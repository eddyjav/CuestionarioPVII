using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Rental
    {
        public int rentalId { get; set; }
        public DateTime rental_date { get; set; }
        public int inventory_id { get; set; }
        
        public DateTime return_date { get; set; }
        public int staff_id { get; set; }
        public DateTime last_update { get; set; }

        public Customer Customer { get; set; }
        public int customerId { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
