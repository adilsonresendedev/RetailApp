﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RetailApp.Data.Context;

#nullable disable

namespace RetailApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RetailApp.Entities.Address", b =>
                {
                    b.Property<int>("IdAdress")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAdress"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MainAdress")
                        .HasColumnType("bit");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAditionalInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAdress");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("RetailApp.Entities.Phone", b =>
                {
                    b.Property<int>("IdPhone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPhone"), 1L, 1);

                    b.Property<bool>("MainPhone")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPhone");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("RetailApp.Entities.Supplier", b =>
                {
                    b.Property<int>("IdSuplier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSuplier"), 1L, 1);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CRT")
                        .HasColumnType("int");

                    b.Property<string>("ComercialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IEST")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSuplier");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("RetailApp.Entities.SupplierAdress", b =>
                {
                    b.Property<int>("IdSupplier")
                        .HasColumnType("int");

                    b.Property<int>("IdAdress")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierIdSuplier")
                        .HasColumnType("int");

                    b.HasKey("IdSupplier", "IdAdress");

                    b.HasIndex("IdAdress");

                    b.HasIndex("SupplierIdSuplier");

                    b.ToTable("SupplierAdresses");
                });

            modelBuilder.Entity("RetailApp.Entities.SupplierPhone", b =>
                {
                    b.Property<int>("IdSupplier")
                        .HasColumnType("int");

                    b.Property<int>("IdPhone")
                        .HasColumnType("int");

                    b.Property<int>("PhoneIdPhone")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierIdSuplier")
                        .HasColumnType("int");

                    b.HasKey("IdSupplier", "IdPhone");

                    b.HasIndex("PhoneIdPhone");

                    b.HasIndex("SupplierIdSuplier");

                    b.ToTable("SupplierPhones");
                });

            modelBuilder.Entity("RetailApp.Entities.SupplierAdress", b =>
                {
                    b.HasOne("RetailApp.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("IdAdress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RetailApp.Entities.Supplier", null)
                        .WithMany("SupplierAdresses")
                        .HasForeignKey("SupplierIdSuplier");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("RetailApp.Entities.SupplierPhone", b =>
                {
                    b.HasOne("RetailApp.Entities.Phone", "Phone")
                        .WithMany()
                        .HasForeignKey("PhoneIdPhone")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RetailApp.Entities.Supplier", null)
                        .WithMany("SuppliersPhones")
                        .HasForeignKey("SupplierIdSuplier");

                    b.Navigation("Phone");
                });

            modelBuilder.Entity("RetailApp.Entities.Supplier", b =>
                {
                    b.Navigation("SupplierAdresses");

                    b.Navigation("SuppliersPhones");
                });
#pragma warning restore 612, 618
        }
    }
}
