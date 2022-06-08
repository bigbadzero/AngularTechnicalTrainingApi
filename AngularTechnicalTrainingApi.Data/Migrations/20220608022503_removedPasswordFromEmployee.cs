using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularTechnicalTrainingApi.Data.Migrations
{
    public partial class removedPasswordFromEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 6, 7, 21, 25, 3, 407, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 6, 7, 21, 25, 3, 407, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 6, 7, 21, 25, 3, 407, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 6, 7, 21, 25, 3, 407, DateTimeKind.Local).AddTicks(2732));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 6, 4, 9, 50, 14, 361, DateTimeKind.Local).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 6, 4, 9, 50, 14, 361, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 6, 4, 9, 50, 14, 361, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 6, 4, 9, 50, 14, 361, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "Admin1Password!");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "Admin2Password!");
        }
    }
}
