using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Identity.Migrations
{
    /// <inheritdoc />
    public partial class RolesOfUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bb99b5c-2c45-4989-8db8-ebc5597a08ec",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "SimpleUser", "SimpleUser" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da118bce-20f4-430d-8844-a0b7e5e045ab", null, "ProUser", "PROUSER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad859e1b-b23b-43d1-b7a1-c5ce852fc98d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dd9d4d8-7308-4b2a-8dc6-89bc6bd3b5d4", "AQAAAAIAAYagAAAAECLaoDONIf/TzDLHm2a02p5jgAGakqqTzVN/E2OLZqeeSM97WqX3tSZcSWSc5cmKYQ==", "dc325aa3-fbc6-40f7-acca-80846e314f7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e44d31c7-e726-45ec-99a8-6a5f5ad13d18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "664ad978-9b31-457e-bc24-7feff1fea686", "AQAAAAIAAYagAAAAEPnhe92LQvcFWpmVeQ6FAxt5eOzL0OOEDhpu7PMnEt03TSuaOmVAofu/rzN9bi4Eng==", "1bf40393-f3a6-47d0-a883-8f8b53ff26e0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da118bce-20f4-430d-8844-a0b7e5e045ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bb99b5c-2c45-4989-8db8-ebc5597a08ec",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Employee", "EMPLOYEE" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad859e1b-b23b-43d1-b7a1-c5ce852fc98d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d59f726f-b0c9-49ea-8a4e-12a88715ac2e", "AQAAAAIAAYagAAAAED+lLVius+XxKbCHnpKJau8phMJkM5dROPSZNV/NrkcO4KEB44FuLrSo4KktdG8ddw==", "eec64f90-adf7-4bcd-849e-1c1f52ab96e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e44d31c7-e726-45ec-99a8-6a5f5ad13d18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65b26911-ccda-4916-95ac-81cd6d4b0de3", "AQAAAAIAAYagAAAAEK5IweA9KZT3BcT4Gr97+raSCjmfFOtQujlyk/LKIjoRQhZSxONd+fa9/SMNQN1KaQ==", "991e5ce0-0b32-4b4d-a3a1-11a8a24cf785" });
        }
    }
}
