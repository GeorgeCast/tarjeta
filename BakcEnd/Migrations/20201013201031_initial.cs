﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BakcEnd.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TarjetaCredito",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titular = table.Column<string>(type: "varchar(45)", nullable: false),
                    NumeroTarjeta = table.Column<string>(type: "varchar(16)", nullable: false),
                    FechaExpiracion = table.Column<string>(type: "varchar(5)", nullable: false),
                    CVV = table.Column<string>(type: "varchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TarjetaCredito", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TarjetaCredito");
        }
    }
}
