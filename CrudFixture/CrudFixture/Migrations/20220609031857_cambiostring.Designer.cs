﻿// <auto-generated />
using System;
using CrudFixture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudFixture.Migrations
{
    [DbContext(typeof(FixtureContext))]
    [Migration("20220609031857_cambiostring")]
    partial class cambiostring
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CrudFixture.Models.Fixture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Dia")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<string>("Estadio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Fecha")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Resultado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Visitante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Fixture");
                });
#pragma warning restore 612, 618
        }
    }
}
