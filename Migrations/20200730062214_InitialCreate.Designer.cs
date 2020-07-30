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
    [Migration("20200730062214_InitialCreate")]
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

                    b.Property<int?>("InstructorId");

                    b.Property<double>("Inversion");

                    b.Property<string>("NombreEvento");

                    b.Property<int>("StockParticipantes");

                    b.Property<string>("estado");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Gestor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApellidoMaterno");

                    b.Property<string>("ApellidoPaterno");

                    b.Property<string>("Celular");

                    b.Property<int>("CodGestor");

                    b.Property<string>("Correo");

                    b.Property<string>("Gestor_Contra");

                    b.Property<string>("Gestor_Usuario");

                    b.Property<string>("PrimerNombre");

                    b.Property<string>("Rol");

                    b.Property<string>("SegundoNombre");

                    b.HasKey("Id");

                    b.ToTable("Gestores");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Gestor_Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventoId");

                    b.Property<int?>("GestorId");

                    b.Property<string>("Motivo");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("GestorId");

                    b.ToTable("Gestor_Eventos");
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

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Pago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CodPago");

                    b.Property<int?>("EventoId");

                    b.Property<DateTime?>("FechaEmision");

                    b.Property<DateTime?>("FechaVenc");

                    b.Property<double>("MontoPago");

                    b.Property<int?>("ParticipanteId");

                    b.Property<int?>("TipoPagoId");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("ParticipanteId");

                    b.HasIndex("TipoPagoId");

                    b.ToTable("Pagos");
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

                    b.Property<string>("pass");

                    b.Property<string>("username");

                    b.HasKey("Id");

                    b.ToTable("Participantes");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Participante_Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comentario");

                    b.Property<int?>("EventoId");

                    b.Property<int?>("ParticipanteId");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("ParticipanteId");

                    b.ToTable("Participante_Eventos");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Tarjeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<char>("CVV")
                        .HasMaxLength(3);

                    b.Property<int>("Cel_Contacto");

                    b.Property<string>("Direccion");

                    b.Property<DateTime?>("FechaVenc_Tarjeta");

                    b.Property<char>("NroTarjeta")
                        .HasMaxLength(16);

                    b.Property<double>("Saldo_Tarjeta");

                    b.HasKey("Id");

                    b.ToTable("Tarjetas");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.TipoPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion_pago");

                    b.HasKey("Id");

                    b.ToTable("TipoPagos");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Evento", b =>
                {
                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Categoria", "Categoria")
                        .WithMany("Eventos")
                        .HasForeignKey("CategoriaId");

                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Gestor_Evento", b =>
                {
                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Evento", "Evento")
                        .WithMany("Gestor_Eventos")
                        .HasForeignKey("EventoId");

                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Gestor", "Gestor")
                        .WithMany("Gestor_Eventos")
                        .HasForeignKey("GestorId");
                });

            modelBuilder.Entity("Sistema_de_Capacitaciones_Virtuales.Models.Pago", b =>
                {
                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId");

                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.Participante", "Participante")
                        .WithMany()
                        .HasForeignKey("ParticipanteId");

                    b.HasOne("Sistema_de_Capacitaciones_Virtuales.Models.TipoPago", "TipoPago")
                        .WithMany()
                        .HasForeignKey("TipoPagoId");
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
