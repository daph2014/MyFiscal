using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFiscal.Data.Migrations
{
    public partial class EntityForeignKeysInit5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KnowledgeEntryDataModel_Research_ResearchId",
                table: "KnowledgeEntryDataModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KnowledgeEntryDataModel",
                table: "KnowledgeEntryDataModel");

            migrationBuilder.RenameTable(
                name: "KnowledgeEntryDataModel",
                newName: "KnowledgeEntries");

            migrationBuilder.RenameIndex(
                name: "IX_KnowledgeEntryDataModel_ResearchId",
                table: "KnowledgeEntries",
                newName: "IX_KnowledgeEntries_ResearchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KnowledgeEntries",
                table: "KnowledgeEntries",
                column: "KnowledgeEntryId");

            migrationBuilder.AddForeignKey(
                name: "FK_KnowledgeEntries_Research_ResearchId",
                table: "KnowledgeEntries",
                column: "ResearchId",
                principalTable: "Research",
                principalColumn: "ResearchId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KnowledgeEntries_Research_ResearchId",
                table: "KnowledgeEntries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KnowledgeEntries",
                table: "KnowledgeEntries");

            migrationBuilder.RenameTable(
                name: "KnowledgeEntries",
                newName: "KnowledgeEntryDataModel");

            migrationBuilder.RenameIndex(
                name: "IX_KnowledgeEntries_ResearchId",
                table: "KnowledgeEntryDataModel",
                newName: "IX_KnowledgeEntryDataModel_ResearchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KnowledgeEntryDataModel",
                table: "KnowledgeEntryDataModel",
                column: "KnowledgeEntryId");

            migrationBuilder.AddForeignKey(
                name: "FK_KnowledgeEntryDataModel_Research_ResearchId",
                table: "KnowledgeEntryDataModel",
                column: "ResearchId",
                principalTable: "Research",
                principalColumn: "ResearchId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
