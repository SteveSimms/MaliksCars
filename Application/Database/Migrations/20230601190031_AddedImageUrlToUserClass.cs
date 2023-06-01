using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaliksCars.Application.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageUrlToUserClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "image_url",
                table: "users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(410), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(420), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(420), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(420), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(430), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(440), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(440), new DateTime(2023, 6, 1, 12, 0, 31, 0, DateTimeKind.Local).AddTicks(440) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image_url",
                table: "users");

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6690), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6730), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6740), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6750), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6760), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6770), new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6770) });
        }
    }
}
