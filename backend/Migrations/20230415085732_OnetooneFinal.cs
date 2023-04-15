using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class OnetooneFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_QuestionModel_CategoryId",
                table: "QuestionModel");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModel_CategoryId",
                table: "QuestionModel",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_QuestionModel_CategoryId",
                table: "QuestionModel");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModel_CategoryId",
                table: "QuestionModel",
                column: "CategoryId",
                unique: true);
        }
    }
}
