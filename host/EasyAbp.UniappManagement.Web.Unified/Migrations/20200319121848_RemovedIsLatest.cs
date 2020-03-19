using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyAbp.UniappManagement.Migrations
{
    public partial class RemovedIsLatest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLatest",
                table: "UniappManagementUniappVersions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLatest",
                table: "UniappManagementUniappVersions",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
