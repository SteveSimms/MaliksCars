using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaliksCars.Application.Database.Migrations
{
    /// <inheritdoc />
    public partial class FixedTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "base_price", "created_at", "updated_at" },
                values: new object[] { "139000", new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3160), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3210), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3210), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3210), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3220), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3230), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3230), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3240), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "base_price", "created_at", "updated_at" },
                values: new object[] { "13900", new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3250), new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3250) });
        }
    }
}
