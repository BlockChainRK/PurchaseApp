﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PurchaseApp.Models;

namespace PurchaseApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191017012928_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("PurchaseApp.Data.Value", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("summary")
                        .HasColumnType("TEXT");

                    b.Property<int>("temperatureC")
                        .HasColumnType("INTEGER");

                    b.Property<int>("temperatureF")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
