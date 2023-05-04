using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _0inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModel_Users_ApplicationUserId1",
                table: "QuestionModel");

            migrationBuilder.DropIndex(
                name: "IX_QuestionModel_ApplicationUserId1",
                table: "QuestionModel");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId1",
                table: "QuestionModel");

            migrationBuilder.AlterColumn<string>(
                name: "ApplicationUserId",
                table: "QuestionModel",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModel_ApplicationUserId",
                table: "QuestionModel",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionModel_Users_ApplicationUserId",
                table: "QuestionModel",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModel_Users_ApplicationUserId",
                table: "QuestionModel");

            migrationBuilder.DropIndex(
                name: "IX_QuestionModel_ApplicationUserId",
                table: "QuestionModel");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationUserId",
                table: "QuestionModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId1",
                table: "QuestionModel",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModel_ApplicationUserId1",
                table: "QuestionModel",
                column: "ApplicationUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionModel_Users_ApplicationUserId1",
                table: "QuestionModel",
                column: "ApplicationUserId1",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
