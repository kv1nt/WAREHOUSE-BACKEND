﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(3000);

                    b.Property<Guid?>("LocationId");

                    b.Property<string>("Name")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("Entities.Models.Lacation", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BuildingNumber");

                    b.Property<string>("City")
                        .HasMaxLength(300);

                    b.Property<string>("CompanyId");

                    b.Property<string>("Country")
                        .HasMaxLength(300);

                    b.Property<decimal>("Latitude");

                    b.Property<decimal>("Longtitude");

                    b.Property<string>("Street")
                        .HasMaxLength(300);

                    b.Property<string>("WarehouseId");

                    b.Property<int>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Entities.Models.Warehouse", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CompanyId")
                        .IsRequired();

                    b.Property<string>("Description")
                        .HasMaxLength(3000);

                    b.Property<Guid?>("LocationId");

                    b.Property<decimal>("Square");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("Entities.Models.Company", b =>
                {
                    b.HasOne("Entities.Models.Lacation", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("Entities.Models.Warehouse", b =>
                {
                    b.HasOne("Entities.Models.Lacation", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });
#pragma warning restore 612, 618
        }
    }
}
