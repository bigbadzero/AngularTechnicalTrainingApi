using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularTechnicalTrainingApi.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "testing",
                table: "Assets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 9, 19, 16, 32, 49, 546, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 9, 19, 16, 32, 49, 546, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 9, 19, 16, 32, 49, 546, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 9, 19, 16, 32, 49, 546, DateTimeKind.Local).AddTicks(1824));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "testing",
                table: "Assets");

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
    }
}
