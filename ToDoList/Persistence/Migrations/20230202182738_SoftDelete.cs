using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SoftDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastModifiedOn",
                table: "ToDoLists",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "ToDoLists",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "LastModifiedOn",
                table: "ToDoItems",
                newName: "LastModifiedAt");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "ToDoItems",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ToDoLists",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "ToDoLists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ToDoItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "ToDoItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ToDoLists");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ToDoLists");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ToDoItems");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ToDoItems");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "ToDoLists",
                newName: "LastModifiedOn");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "ToDoLists",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "LastModifiedAt",
                table: "ToDoItems",
                newName: "LastModifiedOn");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "ToDoItems",
                newName: "CreatedOn");
        }
    }
}
