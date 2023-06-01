using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaliksCars.Application.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddedGWagonToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "id", "base_price", "color", "created_at", "description", "emoji", "image_url", "model", "name", "updated_at", "year" },
                values: new object[] { 13, "13900", "Black", new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3250), "There's nothing else on the road that's quite like the 2023 Mercedes-Benz G-Class. The original G-wagen was an icon, a military vehicle with the interior of an S-Class, and it remained on sale for what seems like forever. The redesigned second-generation version of the SUV arrived in 2019, retaining all of the looks, panache and capability of the original but with a more refined interior and better in-car tech and driver aids. That said, it's far from the most comfortable or best-driving luxury SUV on the road. The G-Class wins on charm more than anything else.", "🏎️", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.ytimg.com%2Fvi%2FRjocMccyxqc%2Fmaxresdefault.jpg&f=1&nofb=1&ipt=7a67a15ccdd6b6b846bcbf15deabdadd61b67d25476b47339ab0680a6f124805&ipo=images", "Amg G63", "Mercedes", new DateTime(2023, 6, 1, 13, 38, 4, 406, DateTimeKind.Local).AddTicks(3250), "2023" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cars",
                keyColumn: "id",
                keyValue: 13);

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
    }
}
