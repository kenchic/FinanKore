using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanKore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCredencialUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                schema: "Perfil",
                table: "Usuarios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PasswordSalt",
                schema: "Perfil",
                table: "Usuarios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                schema: "Perfil",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                schema: "Perfil",
                table: "Usuarios");
        }
    }
}
