using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFiscal.Data.Migrations
{
    public partial class EntityForeignKeysInit7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LifeCategory",
                table: "Research",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LifeCategory",
                table: "Research");
        }
    }
}
