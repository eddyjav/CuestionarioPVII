using Modelo.Entidades;
using ModeloDB;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //RENTALS
            Rental rental1 = new Rental()
            {
                rental_date = DateTime.Now,
                inventory_id = 1,
                return_date = DateTime.Now,
                staff_id = 1,
                last_update = DateTime.Now,
            };
            Rental rental2 = new Rental()
            {
                rental_date = DateTime.Now,
                inventory_id = 2,
                return_date = DateTime.Now,
                staff_id = 2,
                last_update = DateTime.Now,
            };
            Rental rental3 = new Rental()
            {
                rental_date = DateTime.Now,
                inventory_id = 3,
                return_date = DateTime.Now,
                staff_id = 3,
                last_update = DateTime.Now,
            };
            Rental rental4 = new Rental()
            {
                rental_date = DateTime.Now,
                inventory_id = 4,
                return_date = DateTime.Now,
                staff_id = 4,
                last_update = DateTime.Now,
            };
            Rental rental5 = new Rental()
            {
                rental_date = DateTime.Now,
                inventory_id = 5,
                return_date = DateTime.Now,
                staff_id = 5,
                last_update = DateTime.Now,
            };
            Rental rental6 = new Rental()
            {
                rental_date = DateTime.Now,
                inventory_id = 6,
                return_date = DateTime.Now,
                staff_id = 6,
                last_update = DateTime.Now,
            };
            Rental rental7 = new Rental()
            {
                rental_date = DateTime.Now,
                inventory_id = 7,
                return_date = DateTime.Now,
                staff_id = 7,
                last_update = DateTime.Now,
            };
            Rental rental8 = new Rental()
            {
                rental_date = DateTime.Now,
                inventory_id = 8,
                return_date = DateTime.Now,
                staff_id = 8,
                last_update = DateTime.Now,
            };


            //CUSTOMER
            Customer customer1 = new Customer()
            {
                store_Id = 1,
                first_name = "Pedro",
                last_name = "Sanchez",
                email = "ps@gmail.com",
                addres_Id = 1,
                activebool = true,
                create_date = DateTime.Now,
                last_update = DateTime.Now,
                active = false,
                Rental = rental1,
                Payments = new List<Payment>()
            };

            Customer customer2 = new Customer()
            {
                store_Id = 2,
                first_name = "Jose",
                last_name = "Mejia",
                email = "jm@gmail.com",
                addres_Id = 2,
                activebool = true,
                create_date = DateTime.Now,
                last_update = DateTime.Now,
                active = false,
                Rental = rental2,
                Payments = new List<Payment>()
            };
            Customer customer3 = new Customer()
            {
                store_Id = 3,
                first_name = "Andrea",
                last_name = "Samaniego",
                email = "as@gmail.com",
                addres_Id = 3,
                activebool = true,
                create_date = DateTime.Now,
                last_update = DateTime.Now,
                active = false,
                Rental = rental3,
                Payments = new List<Payment>()
            };

            Customer customer4 = new Customer()
            {
                store_Id = 4,
                first_name = "Carolina",
                last_name = "Espinoza",
                email = "ce@gmail.com",
                addres_Id = 4,
                activebool = true,
                create_date = DateTime.Now,
                last_update = DateTime.Now,
                active = false,
                Rental = rental4,
                Payments = new List<Payment>()
            };

            //PAYMENT
            Payment payment1 = new Payment()
            {
                
                staff_id = 1,
                amount = 25.50f,
                payment_date = DateTime.Now,
                Customer = customer1,
                Rental = rental1
            };

            
            Payment payment2 = new Payment()
            {
                
                staff_id = 2,
                amount = 25.50f,
                payment_date = DateTime.Now,
                Customer = customer2,
                Rental = rental2
            };

            Payment payment3 = new Payment()
            {
                
                staff_id = 1,
                amount = 25.50f,
                payment_date = DateTime.Now,
                Customer = customer3,
                Rental = rental3
            };

            Payment payment4 = new Payment()
            {
                
                staff_id = 4,
                amount = 25.50f,
                payment_date = DateTime.Now,
                Customer = customer4,
                Rental = rental4
            };

            Payment payment5 = new Payment()
            {
                
                staff_id = 5,
                amount = 25.50f,
                payment_date = DateTime.Now,
                Customer = customer4,
                Rental = rental5
            };

            Payment payment6 = new Payment()
            {
                
                staff_id = 6,
                amount = 25.50f,
                payment_date = DateTime.Now,
                Customer = customer3,
                Rental = rental6
            };
            


            Repositorio db = new Repositorio();
            db.Payments.Add(payment1);
            db.Payments.Add(payment2);
            db.Payments.Add(payment3);
            db.Payments.Add(payment4);            
            db.SaveChanges();


        }
    }
}
