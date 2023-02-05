using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelationItemToList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoItems_ToDoLists_ToDoListEntityId",
                table: "ToDoItems");

            migrationBuilder.DropIndex(
                name: "IX_ToDoItems_ToDoListEntityId",
                table: "ToDoItems");

            migrationBuilder.DropColumn(
                name: "ToDoListEntityId",
                table: "ToDoItems");

            migrationBuilder.AddColumn<int>(
                name: "ToDoListId",
                table: "ToDoItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ToDoItems_ToDoListId",
                table: "ToDoItems",
                column: "ToDoListId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoItems_ToDoLists_ToDoListId",
                table: "ToDoItems",
                column: "ToDoListId",
                principalTable: "ToDoLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoItems_ToDoLists_ToDoListId",
                table: "ToDoItems");

            migrationBuilder.DropIndex(
                name: "IX_ToDoItems_ToDoListId",
                table: "ToDoItems");

            migrationBuilder.DropColumn(
                name: "ToDoListId",
                table: "ToDoItems");

            migrationBuilder.AddColumn<int>(
                name: "ToDoListEntityId",
                table: "ToDoItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToDoItems_ToDoListEntityId",
                table: "ToDoItems",
                column: "ToDoListEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoItems_ToDoLists_ToDoListEntityId",
                table: "ToDoItems",
                column: "ToDoListEntityId",
                principalTable: "ToDoLists",
                principalColumn: "Id");
        }
    }
}
