using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanKore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Finanzas");

            migrationBuilder.EnsureSchema(
                name: "Proyecto");

            migrationBuilder.EnsureSchema(
                name: "Configuracion");

            migrationBuilder.EnsureSchema(
                name: "Perfil");

            migrationBuilder.CreateTable(
                name: "Categorias",
                schema: "Finanzas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Preferencias",
                schema: "Configuracion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tema = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proyectos",
                schema: "Finanzas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyectos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reportes",
                schema: "Proyecto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProyectoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reportes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                schema: "Perfil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImagenUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FechaRegistro = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    FechaUltimoAcceso = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conceptos",
                schema: "Finanzas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    ProyectoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conceptos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conceptos_Proyectos_ProyectoId",
                        column: x => x.ProyectoId,
                        principalSchema: "Finanzas",
                        principalTable: "Proyectos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConceptoReportes",
                schema: "Proyecto",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    ReporteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConceptoReportes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConceptoReportes_Reportes_ReporteId",
                        column: x => x.ReporteId,
                        principalSchema: "Proyecto",
                        principalTable: "Reportes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "UQ_Categorias_Nombre",
                schema: "Finanzas",
                table: "Categorias",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConceptoReportes_CategoriaId",
                schema: "Proyecto",
                table: "ConceptoReportes",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_ConceptoReportes_ReporteId",
                schema: "Proyecto",
                table: "ConceptoReportes",
                column: "ReporteId");

            migrationBuilder.CreateIndex(
                name: "UQ_ConceptoReportes_ReporteId_Nombre_Tipo_CategoriaId",
                schema: "Proyecto",
                table: "ConceptoReportes",
                columns: new[] { "ReporteId", "Nombre", "Tipo", "CategoriaId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conceptos_CategoriaId",
                schema: "Finanzas",
                table: "Conceptos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Conceptos_ProyectoId",
                schema: "Finanzas",
                table: "Conceptos",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "UQ_Conceptos_ProyectoId_Nombre_CategoriaId",
                schema: "Finanzas",
                table: "Conceptos",
                columns: new[] { "ProyectoId", "Nombre", "CategoriaId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Preferencias_UsuarioId",
                schema: "Configuracion",
                table: "Preferencias",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Correo",
                schema: "Perfil",
                table: "Usuarios",
                column: "Correo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias",
                schema: "Finanzas");

            migrationBuilder.DropTable(
                name: "ConceptoReportes",
                schema: "Proyecto");

            migrationBuilder.DropTable(
                name: "Conceptos",
                schema: "Finanzas");

            migrationBuilder.DropTable(
                name: "Preferencias",
                schema: "Configuracion");

            migrationBuilder.DropTable(
                name: "Usuarios",
                schema: "Perfil");

            migrationBuilder.DropTable(
                name: "Reportes",
                schema: "Proyecto");

            migrationBuilder.DropTable(
                name: "Proyectos",
                schema: "Finanzas");
        }
    }
}
