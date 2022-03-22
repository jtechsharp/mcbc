using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mcbc.Migrations
{
    public partial class Changesinvariousentitiesadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFavoriteCause_AbpUsers_UserId1",
                table: "UserFavoriteCause");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavoriteCause_Causes_CauseId",
                table: "UserFavoriteCause");

            migrationBuilder.DropIndex(
                name: "IX_UserFavoriteCause_UserId1",
                table: "UserFavoriteCause");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserFavoriteCause");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "UserFavoriteCause",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CauseId",
                table: "UserFavoriteCause",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavoriteCause_UserId",
                table: "UserFavoriteCause",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavoriteCause_AbpUsers_UserId",
                table: "UserFavoriteCause",
                column: "UserId",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavoriteCause_Causes_CauseId",
                table: "UserFavoriteCause",
                column: "CauseId",
                principalTable: "Causes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFavoriteCause_AbpUsers_UserId",
                table: "UserFavoriteCause");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFavoriteCause_Causes_CauseId",
                table: "UserFavoriteCause");

            migrationBuilder.DropIndex(
                name: "IX_UserFavoriteCause_UserId",
                table: "UserFavoriteCause");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserFavoriteCause",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CauseId",
                table: "UserFavoriteCause",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "UserId1",
                table: "UserFavoriteCause",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFavoriteCause_UserId1",
                table: "UserFavoriteCause",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavoriteCause_AbpUsers_UserId1",
                table: "UserFavoriteCause",
                column: "UserId1",
                principalTable: "AbpUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFavoriteCause_Causes_CauseId",
                table: "UserFavoriteCause",
                column: "CauseId",
                principalTable: "Causes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
