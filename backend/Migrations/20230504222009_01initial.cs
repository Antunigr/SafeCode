using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class _01initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qid",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "QuestionsId",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Users_QuestionsId",
                table: "Users",
                column: "QuestionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_QuestionModel_QuestionsId",
                table: "Users",
                column: "QuestionsId",
                principalTable: "QuestionModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_QuestionModel_QuestionsId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_QuestionsId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "QuestionsId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Qid",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
