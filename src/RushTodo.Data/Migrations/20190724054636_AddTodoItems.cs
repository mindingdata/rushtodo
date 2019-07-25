using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RushTodo.Data.Migrations
{
    public partial class AddTodoItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoItemEvents",
                columns: table => new
                {
                    AggregateId = table.Column<Guid>(nullable: false),
                    AggregateVersion = table.Column<int>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Serialized = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItemEvents", x => new { x.AggregateId, x.AggregateVersion });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItemEvents");
        }
    }
}
