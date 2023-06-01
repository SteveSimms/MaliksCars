using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaliksCars.Application.Database.Migrations
{
    /// <inheritdoc />
    public partial class Car : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    model = table.Column<string>(type: "TEXT", nullable: false),
                    color = table.Column<string>(type: "TEXT", nullable: false),
                    year = table.Column<string>(type: "TEXT", nullable: false),
                    base_price = table.Column<decimal>(type: "TEXT", nullable: false),
                    image_url = table.Column<string>(type: "TEXT", nullable: false),
                    emoji = table.Column<string>(type: "TEXT", nullable: false),
                    description = table.Column<string>(type: "TEXT", nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cars", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");
        }
    }
}
