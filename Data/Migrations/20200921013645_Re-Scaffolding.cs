using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectionRiches.Data.Migrations
{
    public partial class ReScaffolding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6666b-c83b-4ef7-a002-7fd9746ec7c5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "78b2f41e-4c68-4a31-a4af-ebdd895f8fc7", "6eb0f7b8-b8fa-42e3-967c-996592c08b15", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78b2f41e-4c68-4a31-a4af-ebdd895f8fc7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5c6666b-c83b-4ef7-a002-7fd9746ec7c5", "82484b56-dfaa-4d11-a82b-1a9881353b5d", "Admin", "ADMIN" });
        }
    }
}
