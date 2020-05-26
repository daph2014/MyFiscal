using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFiscal.Data.Migrations
{
    public partial class EntityForeignKeysInit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IssueId",
                table: "Todos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Todos_IssueId",
                table: "Todos",
                column: "IssueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Issues_IssueId",
                table: "Todos",
                column: "IssueId",
                principalTable: "Issues",
                principalColumn: "IssueId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Issues_IssueId",
                table: "Todos");

            migrationBuilder.DropIndex(
                name: "IX_Todos_IssueId",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "IssueId",
                table: "Todos");
        }
    }
}
