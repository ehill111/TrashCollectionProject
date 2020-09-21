using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectionRiches.Data.Migrations
{
    public partial class CreateNewCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2ce8f6d-196e-44bd-a9ac-996158c839b9");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PickUpDay",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "PickUpStatus",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ServiceStartDate",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ServiceStopDate",
                table: "Customer");

            migrationBuilder.AddColumn<int>(
                name: "WorkZone",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RegisterUser",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ConfirmPassword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterUser", x => x.Email);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a5c6666b-c83b-4ef7-a002-7fd9746ec7c5", "82484b56-dfaa-4d11-a82b-1a9881353b5d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisterUser");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5c6666b-c83b-4ef7-a002-7fd9746ec7c5");

            migrationBuilder.DropColumn(
                name: "WorkZone",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PickUpDay",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PickUpStatus",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceStartDate",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceStopDate",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a2ce8f6d-196e-44bd-a9ac-996158c839b9", "b87f7d5b-d244-4e0c-ae12-ee9f66dec99b", "Admin", "ADMIN" });
        }
    }
}
