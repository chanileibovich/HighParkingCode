﻿// <auto-generated />
using System;
using HighParking.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HighParking.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HighParking.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Credit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("StrId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("custommerList");
                });

            modelBuilder.Entity("HighParking.Core.Entities.Invoicing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerType")
                        .HasColumnType("int");

                    b.Property<int>("parkingDetailsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("parkingDetailsId")
                        .IsUnique();

                    b.ToTable("invoicinglist");
                });

            modelBuilder.Entity("HighParking.Core.Entities.ParkingDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Credit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DwellTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Enter")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Exit")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoicingId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("DetailsList");
                });

            modelBuilder.Entity("HighParking.Core.Entities.Invoicing", b =>
                {
                    b.HasOne("HighParking.Core.Entities.Customer", "Customer")
                        .WithMany("Invoicings")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HighParking.Core.Entities.ParkingDetails", "parkingDetails")
                        .WithOne("Invoicing")
                        .HasForeignKey("HighParking.Core.Entities.Invoicing", "parkingDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("parkingDetails");
                });

            modelBuilder.Entity("HighParking.Core.Entities.Customer", b =>
                {
                    b.Navigation("Invoicings");
                });

            modelBuilder.Entity("HighParking.Core.Entities.ParkingDetails", b =>
                {
                    b.Navigation("Invoicing")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
