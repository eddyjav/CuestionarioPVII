using Modelo.Entidades;
using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rental rental1 = new Rental()
            {
                rental_date = DateTime.Now,
                inventory_id = 1,
                return_date = DateTime.Now,
                staff_id = 1,
                last_update = DateTime.Now,
            };

            Payment payment1 = new Payment()
            {
                customerId = 1,
            };

            Customer customer1 = new Customer()
            {
                store_Id = 1,
                first_name = "Pedro",
                last_name = "Sanchez",
                email = "ps@gmail.com"
            };



        }
    }
}
