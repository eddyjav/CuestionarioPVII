using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Customer
    {
        public int customerId { get; set; }
        public int store_Id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public int addres_Id { get; set; }
        public bool activebool { get; set; }
        public DateTime create_date { get; set; }
        public DateTime last_update { get; set; }
        public bool active { get; set; }

        public ICollection<Payment> Payments { get; set; }
        public Rental Rental { get; set; }
    }
}
