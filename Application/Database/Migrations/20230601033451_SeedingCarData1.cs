using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaliksCars.Application.Database.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCarData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "id", "base_price", "color", "created_at", "description", "emoji", "image_url", "model", "name", "updated_at", "year" },
                values: new object[] { 12, "22000", "White", new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6770), "The 2024 Kia Soul EX price may surprise you as it may be around $22,665. The new mini crossover offers a redesigned look and is priced to compete with other small SUVs like the Honda Element and Nissan Cube. The Soul's dimensions are similar to those of a popular SUV, but with the added power of a turbocharged engine.", "🏎️", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.RLM2iRt-V-9CCXlfMHGFUgHaE6%26pid%3DApi&f=1&ipt=2b50cf296d1cb4fbc9cbf36ea642b4fab923dc79c7d31c978601e391c5d5cff2&ipo=images", "Soul", "Kia", new DateTime(2023, 5, 31, 20, 34, 51, 46, DateTimeKind.Local).AddTicks(6770), "2024" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cars",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(1950), new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(1990), new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2000), new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2000), new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2050), new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2060), new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2060), new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2060), new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2070), new DateTime(2023, 5, 31, 20, 2, 35, 126, DateTimeKind.Local).AddTicks(2070) });
        }
    }
}
