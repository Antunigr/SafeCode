using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class ManytoMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriesModel",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Java = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Csharp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ruby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kotlin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Php = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Python = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NodeJs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Javascript = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Html = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Css = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    React = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    C = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BancoDeDados = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cloud = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Api = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Android = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesModel", x => x.CategoriesId);
                });

            migrationBuilder.CreateTable(
                name: "QuestionModel",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeArea = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionModel", x => x.QuestionId);
                });

            migrationBuilder.CreateTable(
                name: "QuestionCategoriesModel",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionCategoriesModel", x => new { x.QuestionId, x.CategoriesId });
                    table.ForeignKey(
                        name: "FK_QuestionCategoriesModel_CategoriesModel_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "CategoriesModel",
                        principalColumn: "CategoriesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionCategoriesModel_QuestionModel_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionModel",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionCategoriesModel_CategoriesId",
                table: "QuestionCategoriesModel",
                column: "CategoriesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionCategoriesModel");

            migrationBuilder.DropTable(
                name: "CategoriesModel");

            migrationBuilder.DropTable(
                name: "QuestionModel");
        }
    }
}
