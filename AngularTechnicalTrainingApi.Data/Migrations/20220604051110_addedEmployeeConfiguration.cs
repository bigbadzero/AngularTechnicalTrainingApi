using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularTechnicalTrainingApi.Data.Migrations
{
    public partial class addedEmployeeConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { 1, "Admin1@gmail.com", "Admin1", "Admin1Password!" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { 2, "Admin2@gmail.com", "Admin2", "Admin2Password!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
