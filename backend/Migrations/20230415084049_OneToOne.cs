using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class OneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriesTagId",
                table: "QuestionModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModel_CategoriesModel_CategoriesTagId",
                table: "QuestionModel");

            migrationBuilder.DropIndex(
                name: "IX_QuestionModel_CategoriesTagId",
                table: "QuestionModel");

            migrationBuilder.DropColumn(
                name: "CategoriesTagId",
                table: "QuestionModel");
        }
    }
}
