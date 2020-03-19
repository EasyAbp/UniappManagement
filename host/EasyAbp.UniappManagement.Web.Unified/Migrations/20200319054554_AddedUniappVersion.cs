using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyAbp.UniappManagement.Migrations
{
    public partial class AddedUniappVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniappManagementUniappVersions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    TenantId = table.Column<Guid>(nullable: true),
                    AppId = table.Column<Guid>(nullable: false),
                    BuildNumber = table.Column<long>(nullable: false),
                    Tag = table.Column<string>(nullable: true),
                    WgtUrl = table.Column<string>(nullable: true),
                    PkgUrl = table.Column<string>(nullable: true),
                    IsLatest = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniappManagementUniappVersions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniappManagementUniappVersions");
        }
    }
}
