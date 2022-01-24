using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    public class Repositorio : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-V7VPQBI;Initial Catalog=Cuestionario;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            
            model.Entity<Payment>()
                .HasOne(p => p.Customer)
                .WithMany(c => c.Payments)
                .HasForeignKey(p => p.customerId);

            model.Entity<Customer>()
                .HasOne(c => c.Rental)
                .WithOne(r => r.Customer)
                .HasForeignKey<Rental>(r => r.customerId);

            model.Entity<Payment>()
                .HasOne(p => p.Rental)
                .WithMany(r => r.Payments)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(p => p.rental_id);               
            
        }


    }
}
