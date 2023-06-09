﻿// <auto-generated />
using System;
using BikeFitBasic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BikeFitBasic.Migrations
{
    [DbContext(typeof(BikeFitBasicContext))]
    [Migration("20230425154824_Inicio")]
    partial class Inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("BikeFitBasic.Models.Ciclista", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Data")
                        .HasColumnType("TEXT");

                    b.Property<int>("MedidaAntebraco")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MedidaCavalo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NivelFlexibilidade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Ciclistas");
                });
#pragma warning restore 612, 618
        }
    }
}
