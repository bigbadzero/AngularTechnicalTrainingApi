using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularTechnicalTrainingApi.Data.Migrations
{
    public partial class removedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "testing",
                table: "Assets");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 9, 9, 7, 59, 73, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 9, 9, 7, 59, 73, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 11, 9, 9, 7, 59, 73, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "TagID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2022, 11, 9, 9, 7, 59, 73, DateTimeKind.Local).AddTicks(6595));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
