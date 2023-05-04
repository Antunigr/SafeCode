using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _9initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModel_Users_ApplicationUserRefId",
                table: "QuestionModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_QuestionModel_ApplicationUserRefId",
                table: "QuestionModel");

            migrationBuilder.DropColumn(
                name: "ApplicationUserRefId",
                table: "QuestionModel");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Qid",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Qid");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModel_ApplicationUserId",
                table: "QuestionModel",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionModel_Users_ApplicationUserId",
                table: "QuestionModel",
                column: "ApplicationUserId",
                principalTable: "Users",
                principalColumn: "Qid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModel_Users_ApplicationUserId",
                table: "QuestionModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_QuestionModel_ApplicationUserId",
                table: "QuestionModel");

            migrationBuilder.DropColumn(
                name: "Qid",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserRefId",
                table: "QuestionModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModel_ApplicationUserRefId",
                table: "QuestionModel",
                column: "ApplicationUserRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionModel_Users_ApplicationUserRefId",
                table: "QuestionModel",
                column: "ApplicationUserRefId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
