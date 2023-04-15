using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class OneToOne2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModel_CategoriesModel_CategoriesTagId",
                table: "QuestionModel");

            migrationBuilder.DropIndex(
                name: "IX_QuestionModel_CategoriesTagId",
                table: "QuestionModel");

            migrationBuilder.RenameColumn(
                name: "CategoriesTagId",
                table: "QuestionModel",
                newName: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModel_CategoryId",
                table: "QuestionModel",
                column: "CategoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionModel_CategoriesModel_CategoryId",
                table: "QuestionModel",
                column: "CategoryId",
                principalTable: "CategoriesModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModel_CategoriesModel_CategoryId",
                table: "QuestionModel");

            migrationBuilder.DropIndex(
                name: "IX_QuestionModel_CategoryId",
                table: "QuestionModel");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "QuestionModel",
                newName: "CategoriesTagId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModel_CategoriesTagId",
                table: "QuestionModel",
                column: "CategoriesTagId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionModel_CategoriesModel_CategoriesTagId",
                table: "QuestionModel",
                column: "CategoriesTagId",
                principalTable: "CategoriesModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
