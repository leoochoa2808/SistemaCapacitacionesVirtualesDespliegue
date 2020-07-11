using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SistemadeCapacitacionesVirtuales.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NombreCategoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructor_Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodInstructor = table.Column<int>(nullable: false),
                    CodEvento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor_Eventos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participante_Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodParticipante = table.Column<int>(nullable: false),
                    CodEvento = table.Column<int>(nullable: false),
                    Participante_EventoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participante_Eventos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodInstructor = table.Column<int>(nullable: false),
                    PrimerNombre = table.Column<string>(nullable: true),
                    SegundoNombre = table.Column<string>(nullable: true),
                    ApellidoPaterno = table.Column<string>(nullable: true),
                    ApelidoMaterno = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    celular = table.Column<int>(nullable: false),
                    Instructor_EventoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructores_Instructor_Eventos_Instructor_EventoId",
                        column: x => x.Instructor_EventoId,
                        principalTable: "Instructor_Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CategoriaId = table.Column<int>(nullable: true),
                    NombreEvento = table.Column<string>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: true),
                    FechaFin = table.Column<DateTime>(nullable: true),
                    HoraInicio = table.Column<DateTime>(nullable: true),
                    HoraFin = table.Column<DateTime>(nullable: true),
                    StockParticipantes = table.Column<int>(nullable: false),
                    Inversion = table.Column<double>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    estado = table.Column<string>(nullable: true),
                    FechConfirmacion = table.Column<DateTime>(nullable: true),
                    Frecuencia = table.Column<string>(nullable: true),
                    Instructor_EventoId = table.Column<int>(nullable: true),
                    Participante_EventoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eventos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Eventos_Instructor_Eventos_Instructor_EventoId",
                        column: x => x.Instructor_EventoId,
                        principalTable: "Instructor_Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Eventos_Participante_Eventos_Participante_EventoId",
                        column: x => x.Participante_EventoId,
                        principalTable: "Participante_Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Participantes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodParticipante = table.Column<int>(nullable: false),
                    PrimerNombre = table.Column<string>(nullable: true),
                    SegundoNombre = table.Column<string>(nullable: true),
                    ApellidoPaterno = table.Column<string>(nullable: true),
                    ApelidoMaterno = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    celular = table.Column<int>(nullable: false),
                    Participante_EventoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participantes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participantes_Participante_Eventos_Participante_EventoId",
                        column: x => x.Participante_EventoId,
                        principalTable: "Participante_Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_CategoriaId",
                table: "Eventos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_Instructor_EventoId",
                table: "Eventos",
                column: "Instructor_EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_Participante_EventoId",
                table: "Eventos",
                column: "Participante_EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructores_Instructor_EventoId",
                table: "Instructores",
                column: "Instructor_EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Participantes_Participante_EventoId",
                table: "Participantes",
                column: "Participante_EventoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Instructores");

            migrationBuilder.DropTable(
                name: "Participantes");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Instructor_Eventos");

            migrationBuilder.DropTable(
                name: "Participante_Eventos");
        }
    }
}
