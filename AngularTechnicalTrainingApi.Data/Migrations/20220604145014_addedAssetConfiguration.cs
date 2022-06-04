using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularTechnicalTrainingApi.Data.Migrations
{
    public partial class addedAssetConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRetired",
                table: "Assets",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "TagID", "AssetTypeID", "DateAdded", "DateRetired", "Description", "EmployeeID", "Retired" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 6, 4, 9, 50, 14, 361, DateTimeKind.Local).AddTicks(3554), null, "Desktop assigned to Admin1", 1, false },
                    { 2, 2, new DateTime(2022, 6, 4, 9, 50, 14, 361, DateTimeKind.Local).AddTicks(3590), null, "Standard Laptop assigned to Admin1", 1, false },
                    { 3, 1, new DateTime(2022, 6, 4, 9, 50, 14, 361, DateTimeKind.Local).AddTicks(3594), null, "Standard Desktop assigned to Admin2", 2, false },
                    { 4, 2, new DateTime(2022, 6, 4, 9, 50, 14, 361, DateTimeKind.Local).AddTicks(3596), null, "Standard Laptop assigned to Admin2", 2, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRetired",
                table: "Assets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
