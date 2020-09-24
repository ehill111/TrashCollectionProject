using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollectionRiches.Migrations
{
    public partial class UpdatedScaffolding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "City",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "Employee");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeViewDay",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PickUpCompleted",
                table: "Employee",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "SpecialPickUpDate",
                table: "Customer",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<bool>(
                name: "PickUpCompleted",
                table: "Customer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5054e7bf-0811-4bcc-a4c5-45811118388d", "500533f9-fa15-45c1-bb0e-5f01a99f56ab", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "edbee1e6-c3f6-4d72-ae76-be8b4b9f7d14", "30cf2bdb-47e6-4dff-9f47-76c8f3b31e9e", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5054e7bf-0811-4bcc-a4c5-45811118388d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edbee1e6-c3f6-4d72-ae76-be8b4b9f7d14");

            migrationBuilder.DropColumn(
                name: "EmployeeViewDay",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PickUpCompleted",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "PickUpCompleted",
                table: "Customer");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SpecialPickUpDate",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19c99926-3190-4e93-ac09-7468bf494ea8", "9ba949fc-35c8-42c3-a4a9-e41bcf26921a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ab8672df-fc92-4499-86a7-997ed99d2fc1", "519ed5d6-ed5e-4e8e-8f38-d446e9da09f7", "Employee", "EMPLOYEE" });
        }
    }
}
