using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _5342initial645640 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_QuestionModel_QuestionsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IquestionsString",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "QuestionsId",
                table: "Users",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_QuestionsId",
                table: "Users",
                newName: "IX_Users_QuestionId");

            migrationBuilder.AddColumn<string>(
                name: "Questions",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_QuestionModel_QuestionId",
                table: "Users",
                column: "QuestionId",
                principalTable: "QuestionModel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_QuestionModel_QuestionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Questions",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Users",
                newName: "QuestionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_QuestionId",
                table: "Users",
                newName: "IX_Users_QuestionsId");

            migrationBuilder.AddColumn<string>(
                name: "IquestionsString",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_QuestionModel_QuestionsId",
                table: "Users",
                column: "QuestionsId",
                principalTable: "QuestionModel",
                principalColumn: "Id");
        }
    }
}
