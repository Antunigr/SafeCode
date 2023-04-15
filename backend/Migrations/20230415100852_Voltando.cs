using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Voltando : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModel_CategoriesModel_CategoryId",
                table: "QuestionModel");

            migrationBuilder.DropIndex(
                name: "IX_QuestionModel_CategoryId",
                table: "QuestionModel");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "QuestionModel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "QuestionModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModel_CategoryId",
                table: "QuestionModel",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionModel_CategoriesModel_CategoryId",
                table: "QuestionModel",
                column: "CategoryId",
                principalTable: "CategoriesModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
