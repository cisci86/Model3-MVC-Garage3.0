﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Garage_2._0.Migrations
{
    [DbContext(typeof(GarageVehicleContext))]
    [Migration("20220201131230_seeddata")]
    partial class seeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Garage_2._0.Models.Vehicle", b =>
                {
                    b.Property<string>("License")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("datetime2");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Model")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Wheels")
                        .HasColumnType("int");

                    b.HasKey("License");

                    b.ToTable("Vehicle");

                    b.HasData(
                        new
                        {
                            License = "Abc123",
                            Arrival = new DateTime(2022, 2, 1, 12, 9, 28, 0, DateTimeKind.Unspecified),
                            Color = "Red",
                            Make = "Volvo",
                            Model = "Xc60",
                            Type = 0,
                            Wheels = 4
                        },
                        new
                        {
                            License = "Bcd123",
                            Arrival = new DateTime(2022, 2, 1, 13, 9, 28, 0, DateTimeKind.Unspecified),
                            Color = "White",
                            Make = "Volvo",
                            Model = "Xc60",
                            Type = 0,
                            Wheels = 4
                        },
                        new
                        {
                            License = "Cde123",
                            Arrival = new DateTime(2022, 2, 1, 14, 9, 28, 0, DateTimeKind.Unspecified),
                            Color = "Yellow",
                            Make = "Volvo",
                            Model = "Xc60",
                            Type = 2,
                            Wheels = 2
                        },
                        new
                        {
                            License = "Def123",
                            Arrival = new DateTime(2022, 2, 1, 15, 9, 28, 0, DateTimeKind.Unspecified),
                            Color = "Blue",
                            Make = "Volvo",
                            Model = "Xc60",
                            Type = 1,
                            Wheels = 8
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
