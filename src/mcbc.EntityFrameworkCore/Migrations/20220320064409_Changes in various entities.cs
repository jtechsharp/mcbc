using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mcbc.Migrations
{
    public partial class Changesinvariousentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Causes_ContactPerson_ContactPersonId",
                table: "Causes");

            migrationBuilder.DropForeignKey(
                name: "FK_Causes_NGOs_NGOId",
                table: "Causes");

            migrationBuilder.DropForeignKey(
                name: "FK_NGOs_ContactPerson_ContactPersonId",
                table: "NGOs");

            migrationBuilder.DropTable(
                name: "ContactPerson");

            migrationBuilder.DropIndex(
                name: "IX_NGOs_ContactPersonId",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "UserFavoriteCause");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "UserFavoriteCause");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "UserFavoriteCause");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "MembershipRequests");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "MembershipRequests");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MembershipRequests");

            migrationBuilder.RenameColumn(
                name: "Sector",
                table: "NGOs",
                newName: "ContactPersonEmail");

            migrationBuilder.RenameColumn(
                name: "ContactPersonId",
                table: "NGOs",
                newName: "TenantId");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Causes",
                newName: "ContactPersonName");

            migrationBuilder.RenameColumn(
                name: "ContactPersonId",
                table: "Causes",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Causes_ContactPersonId",
                table: "Causes",
                newName: "IX_Causes_CountryId");

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "UserFavoriteCause",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonName",
                table: "NGOs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonPhone",
                table: "NGOs",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectorId",
                table: "NGOs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "MembershipRequests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Donations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "NGOId",
                table: "Causes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonEmail",
                table: "Causes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonPhone",
                table: "Causes",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Causes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NGOs_SectorId",
                table: "NGOs",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_NGOs_TenantId",
                table: "NGOs",
                column: "TenantId",
                unique: true,
                filter: "[TenantId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Causes_Country_CountryId",
                table: "Causes",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Causes_NGOs_NGOId",
                table: "Causes",
                column: "NGOId",
                principalTable: "NGOs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NGOs_AbpTenants_TenantId",
                table: "NGOs",
                column: "TenantId",
                principalTable: "AbpTenants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NGOs_Sectors_SectorId",
                table: "NGOs",
                column: "SectorId",
                principalTable: "Sectors",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Causes_Country_CountryId",
                table: "Causes");

            migrationBuilder.DropForeignKey(
                name: "FK_Causes_NGOs_NGOId",
                table: "Causes");

            migrationBuilder.DropForeignKey(
                name: "FK_NGOs_AbpTenants_TenantId",
                table: "NGOs");

            migrationBuilder.DropForeignKey(
                name: "FK_NGOs_Sectors_SectorId",
                table: "NGOs");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_NGOs_SectorId",
                table: "NGOs");

            migrationBuilder.DropIndex(
                name: "IX_NGOs_TenantId",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "UserFavoriteCause");

            migrationBuilder.DropColumn(
                name: "ContactPersonName",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "ContactPersonPhone",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "SectorId",
                table: "NGOs");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "MembershipRequests");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Donations");

            migrationBuilder.DropColumn(
                name: "ContactPersonEmail",
                table: "Causes");

            migrationBuilder.DropColumn(
                name: "ContactPersonPhone",
                table: "Causes");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Causes");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "NGOs",
                newName: "ContactPersonId");

            migrationBuilder.RenameColumn(
                name: "ContactPersonEmail",
                table: "NGOs",
                newName: "Sector");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Causes",
                newName: "ContactPersonId");

            migrationBuilder.RenameColumn(
                name: "ContactPersonName",
                table: "Causes",
                newName: "Country");

            migrationBuilder.RenameIndex(
                name: "IX_Causes_CountryId",
                table: "Causes",
                newName: "IX_Causes_ContactPersonId");

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "UserFavoriteCause",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "UserFavoriteCause",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "UserFavoriteCause",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "MembershipRequests",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "MembershipRequests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MembershipRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "NGOId",
                table: "Causes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ContactPerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactPersonEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactPersonName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactPersonPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPerson", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NGOs_ContactPersonId",
                table: "NGOs",
                column: "ContactPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Causes_ContactPerson_ContactPersonId",
                table: "Causes",
                column: "ContactPersonId",
                principalTable: "ContactPerson",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Causes_NGOs_NGOId",
                table: "Causes",
                column: "NGOId",
                principalTable: "NGOs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NGOs_ContactPerson_ContactPersonId",
                table: "NGOs",
                column: "ContactPersonId",
                principalTable: "ContactPerson",
                principalColumn: "Id");
        }
    }
}
