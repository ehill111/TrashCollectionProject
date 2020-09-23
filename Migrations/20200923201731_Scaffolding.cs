using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectionRiches.Migrations
{
    public partial class Scaffolding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49488df7-93cc-4008-91f5-1bf927ce5835");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ad27bb8-9188-4795-8cf9-3fe8bf6d1521");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Employee",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19c99926-3190-4e93-ac09-7468bf494ea8", "9ba949fc-35c8-42c3-a4a9-e41bcf26921a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab8672df-fc92-4499-86a7-997ed99d2fc1", "519ed5d6-ed5e-4e8e-8f38-d446e9da09f7", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19c99926-3190-4e93-ac09-7468bf494ea8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab8672df-fc92-4499-86a7-997ed99d2fc1");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Employee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ad27bb8-9188-4795-8cf9-3fe8bf6d1521", "7ce0e677-3bfc-4547-b734-1a9e0b65321f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49488df7-93cc-4008-91f5-1bf927ce5835", "dcf933e0-da2b-432c-92f4-499034f87c49", "Employee", "EMPLOYEE" });
        }
    }
}
