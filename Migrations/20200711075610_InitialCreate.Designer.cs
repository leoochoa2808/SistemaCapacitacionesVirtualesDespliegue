﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Sistema_de_Capacitaciones_Virtuales.Models;

namespace SistemadeCapacitacionesVirtuales.Migrations
{
    [DbContext(typeof(KleerDbContext))]
    [Migration("20200711075610_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NombreCategoria");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoriaId");

                    b.Property<string>("Descripcion");

                    b.Property<DateTime?>("FechConfirmacion");

                    b.Property<DateTime?>("FechaFin");

                    b.Property<DateTime?>("FechaInicio");

                    b.Property<string>("Frecuencia");

                    b.Property<DateTime?>("HoraFin");

                    b.Property<DateTime?>("HoraInicio");

                    b.Property<int?>("Instructor_EventoId");

                    b.Property<double>("Inversion");

                    b.Property<string>("NombreEvento");

                    b.Property<int?>("Participante_EventoId");

                    b.Property<int>("StockParticipantes");

                    b.Property<string>("estado");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("Instructor_EventoId");

                    b.HasIndex("Participante_EventoId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApellidoMaterno");

                    b.Property<string>("ApellidoPaterno");

                    b.Property<int>("Celular");

                    b.Property<int>("CodInstructor");

                    b.Property<string>("Correo");

                    b.Property<int?>("Instructor_EventoId");

                    b.Property<string>("PrimerNombre");

                    b.Property<string>("SegundoNombre");

                    b.HasKey("Id");

                    b.HasIndex("Instructor_EventoId");

                    b.ToTable("Instructores");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Instructor_Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CodEvento");

                    b.Property<int>("CodInstructor");

                    b.HasKey("Id");

                    b.ToTable("Instructor_Eventos");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Participante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApellidoMaterno");

                    b.Property<string>("ApellidoPaterno");

                    b.Property<int>("Celular");

                    b.Property<int>("CodParticipante");

                    b.Property<string>("Correo");

                    b.Property<int?>("Participante_EventoId");

                    b.Property<string>("PrimerNombre");

                    b.Property<string>("SegundoNombre");

                    b.HasKey("Id");

                    b.HasIndex("Participante_EventoId");

                    b.ToTable("Participantes");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Participante_Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CodEvento");

                    b.Property<int>("CodParticipante");

                    b.Property<int?>("Participante_EventoId");

                    b.HasKey("Id");

                    b.ToTable("Participante_Eventos");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Evento", b =>
                {
                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Categoria", "Categoria")
                        .WithMany("Eventos")
                        .HasForeignKey("CategoriaId");

                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Instructor_Evento", "Instructor_Evento")
                        .WithMany("Eventos")
                        .HasForeignKey("Instructor_EventoId");

                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Participante_Evento", "Participante_Evento")
                        .WithMany("Eventos")
                        .HasForeignKey("Participante_EventoId");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Instructor", b =>
                {
                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Instructor_Evento", "Instructor_Evento")
                        .WithMany("Instructores")
                        .HasForeignKey("Instructor_EventoId");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Participante", b =>
                {
                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Participante_Evento", "Participante_Evento")
                        .WithMany("Participantes")
                        .HasForeignKey("Participante_EventoId");
                });
#pragma warning restore 612, 618
        }
    }
}
