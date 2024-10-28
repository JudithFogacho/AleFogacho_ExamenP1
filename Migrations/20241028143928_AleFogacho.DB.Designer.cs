﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AleFogacho_ExamenP1.Migrations
{
    [DbContext(typeof(AleFogacho_ExamenP1Context))]
    [Migration("20241028143928_AleFogacho.DB")]
    partial class AleFogachoDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AleFogacho_ExamenP1.Models.AF_Cita", b =>
                {
                    b.Property<int>("AF_CitaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AF_CitaId"));

                    b.Property<string>("AF_Detalle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("AF_FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("AF_NombreCita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AF_Seguro")
                        .HasColumnType("bit");

                    b.Property<decimal>("AF_ValorCita")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AF_CitaId");

                    b.ToTable("AF_Cita");
                });
#pragma warning restore 612, 618
        }
    }
}
