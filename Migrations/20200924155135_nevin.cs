using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectionRiches.Migrations
{
    public partial class nevin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5054e7bf-0811-4bcc-a4c5-45811118388d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edbee1e6-c3f6-4d72-ae76-be8b4b9f7d14");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00888a61-f4c6-43f3-921c-819a07014837", "7324a9b1-0087-4422-855f-70ebe9c82473", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7ab6915d-1c98-4e22-9483-4817dcae4815", "6a5efd7d-e95d-44fd-89a2-2701419c1dd8", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00888a61-f4c6-43f3-921c-819a07014837");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ab6915d-1c98-4e22-9483-4817dcae4815");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5054e7bf-0811-4bcc-a4c5-45811118388d", "500533f9-fa15-45c1-bb0e-5f01a99f56ab", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "edbee1e6-c3f6-4d72-ae76-be8b4b9f7d14", "30cf2bdb-47e6-4dff-9f47-76c8f3b31e9e", "Employee", "EMPLOYEE" });
        }
    }
}
