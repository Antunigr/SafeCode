using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriesModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_CategoriesModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeArea = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionModel", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesModel");

            migrationBuilder.DropTable(
                name: "QuestionModel");
        }
    }
}
