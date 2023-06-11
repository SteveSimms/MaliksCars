using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaliksCars.Application.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddUserFavoriteCarTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "user_favorite_cars",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "INTEGER", nullable: false),
                    car_id = table.Column<int>(type: "INTEGER", nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    updated_at = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user_favorite_cars", x => new { x.user_id, x.car_id });
                    table.ForeignKey(
                        name: "fk_user_favorite_cars_cars_car_id",
                        column: x => x.car_id,
                        principalTable: "cars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_favorite_cars_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4650), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4700), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4730), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4730), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4730), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4730), new DateTime(2023, 6, 10, 20, 19, 58, 651, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.CreateIndex(
                name: "ix_user_favorite_cars_car_id",
                table: "user_favorite_cars",
                column: "car_id");

            migrationBuilder.CreateIndex(
                name: "ix_user_favorite_cars_user_id",
                table: "user_favorite_cars",
                column: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_favorite_cars");

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
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810), new DateTime(2023, 6, 1, 13, 40, 39, 985, DateTimeKind.Local).AddTicks(7810) });
        }
    }
}
