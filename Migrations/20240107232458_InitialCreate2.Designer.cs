﻿// <auto-generated />
using System;
using Gym_Bobescu.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gym_Bobescu.Migrations
{
    [DbContext(typeof(Gym_BobescuContext))]
    [Migration("20240107232458_InitialCreate2")]
    partial class InitialCreate2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gym_Bobescu.Models.Antrenor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("NumeAntrenor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Antrenor");
                });

            modelBuilder.Entity("Gym_Bobescu.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AntrenorID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Born")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Greutate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AntrenorID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Gym_Bobescu.Models.Client", b =>
                {
                    b.HasOne("Gym_Bobescu.Models.Antrenor", "Antrenor")
                        .WithMany("Clienti")
                        .HasForeignKey("AntrenorID");

                    b.Navigation("Antrenor");
                });

            modelBuilder.Entity("Gym_Bobescu.Models.Antrenor", b =>
                {
                    b.Navigation("Clienti");
                });
#pragma warning restore 612, 618
        }
    }
}