using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFiscal.Data.Migrations
{
    public partial class EntityForeignKeysInit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IssueId",
                table: "Research",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Research",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Research_IssueId",
                table: "Research",
                column: "IssueId");

            migrationBuilder.CreateIndex(
                name: "IX_Research_ProjectId",
                table: "Research",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Research_Issues_IssueId",
                table: "Research",
                column: "IssueId",
                principalTable: "Issues",
                principalColumn: "IssueId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Research_Projects_ProjectId",
                table: "Research",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Research_Issues_IssueId",
                table: "Research");

            migrationBuilder.DropForeignKey(
                name: "FK_Research_Projects_ProjectId",
                table: "Research");

            migrationBuilder.DropIndex(
                name: "IX_Research_IssueId",
                table: "Research");

            migrationBuilder.DropIndex(
                name: "IX_Research_ProjectId",
                table: "Research");

            migrationBuilder.DropColumn(
                name: "IssueId",
                table: "Research");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Research");
        }
    }
}
