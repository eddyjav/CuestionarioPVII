﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloDB;

namespace ModeloDB.Migrations
{
    [DbContext(typeof(Repositorio))]
    [Migration("20220124234555_Cuestionario1")]
    partial class Cuestionario1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modelo.Entidades.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("active")
                        .HasColumnType("bit");

                    b.Property<bool>("activebool")
                        .HasColumnType("bit");

                    b.Property<int>("addres_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("last_update")
                        .HasColumnType("datetime2");

                    b.Property<int>("store_Id")
                        .HasColumnType("int");

                    b.HasKey("customerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Modelo.Entidades.Payment", b =>
                {
                    b.Property<int>("paymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("amount")
                        .HasColumnType("real");

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("payment_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("rental_id")
                        .HasColumnType("int");

                    b.Property<int>("staff_id")
                        .HasColumnType("int");

                    b.HasKey("paymentId");

                    b.HasIndex("customerId");

                    b.HasIndex("rental_id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Modelo.Entidades.Rental", b =>
                {
                    b.Property<int>("rentalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("customerId")
                        .HasColumnType("int");

                    b.Property<int>("inventory_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("last_update")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("rental_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("return_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("staff_id")
                        .HasColumnType("int");

                    b.HasKey("rentalId");

                    b.HasIndex("customerId")
                        .IsUnique();

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("Modelo.Entidades.Payment", b =>
                {
                    b.HasOne("Modelo.Entidades.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modelo.Entidades.Rental", "Rental")
                        .WithMany("Payments")
                        .HasForeignKey("rental_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("Modelo.Entidades.Rental", b =>
                {
                    b.HasOne("Modelo.Entidades.Customer", "Customer")
                        .WithOne("Rental")
                        .HasForeignKey("Modelo.Entidades.Rental", "customerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Modelo.Entidades.Customer", b =>
                {
                    b.Navigation("Payments");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("Modelo.Entidades.Rental", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
