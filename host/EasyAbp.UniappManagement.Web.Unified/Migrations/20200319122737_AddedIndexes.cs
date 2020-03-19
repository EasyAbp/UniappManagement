using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyAbp.UniappManagement.Migrations
{
    public partial class AddedIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UniappManagementUniapps",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UniappManagementUniappVersions_AppId",
                table: "UniappManagementUniappVersions",
                column: "AppId");

            migrationBuilder.CreateIndex(
                name: "IX_UniappManagementUniapps_Name",
                table: "UniappManagementUniapps",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UniappManagementUniappVersions_AppId",
                table: "UniappManagementUniappVersions");

            migrationBuilder.DropIndex(
                name: "IX_UniappManagementUniapps_Name",
                table: "UniappManagementUniapps");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UniappManagementUniapps",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
