﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Sistema_de_Capacitaciones_Virtuales.Models;

namespace SistemadeCapacitacionesVirtuales.Migrations
{
    [DbContext(typeof(KleerDbContext))]
    partial class KleerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<double>("Inversion");

                    b.Property<string>("NombreEvento");

                    b.Property<int>("StockParticipantes");

                    b.Property<string>("estado");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApellidoMaterno");

                    b.Property<string>("ApellidoPaterno");

                    b.Property<string>("Celular");

                    b.Property<string>("CodInstructor");

                    b.Property<string>("Correo");

                    b.Property<string>("PrimerNombre");

                    b.Property<string>("SegundoNombre");

                    b.HasKey("Id");

                    b.ToTable("Instructores");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Instructor_Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventoId");

                    b.Property<int?>("InstructorId");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Instructor_Eventos");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Participante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApellidoMaterno");

                    b.Property<string>("ApellidoPaterno");

                    b.Property<string>("Celular");

                    b.Property<string>("CodParticipante");

                    b.Property<string>("Correo");

                    b.Property<string>("PrimerNombre");

                    b.Property<string>("SegundoNombre");

                    b.HasKey("Id");

                    b.ToTable("Participantes");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Participante_Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventoId");

                    b.Property<int?>("ParticipanteId");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("ParticipanteId");

                    b.ToTable("Participante_Eventos");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Evento", b =>
                {
                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Categoria", "Categoria")
                        .WithMany("Eventos")
                        .HasForeignKey("CategoriaId");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Instructor_Evento", b =>
                {
                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Evento", "Evento")
                        .WithMany("Instructor_Eventos")
                        .HasForeignKey("EventoId");

                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Instructor", "Instructor")
                        .WithMany("Instructor_Eventos")
                        .HasForeignKey("InstructorId");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Participante_Evento", b =>
                {
                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Evento", "Evento")
                        .WithMany("Participante_Eventos")
                        .HasForeignKey("EventoId");

                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Participante", "Participante")
                        .WithMany("Participante_Eventos")
                        .HasForeignKey("ParticipanteId");
                });
#pragma warning restore 612, 618
        }
    }
}
