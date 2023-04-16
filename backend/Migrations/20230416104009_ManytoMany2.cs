using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class ManytoMany2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Android",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "Api",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "BancoDeDados",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "C",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "Cloud",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "Csharp",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "Css",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "Html",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "Java",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "Javascript",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "Kotlin",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "NodeJs",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "Php",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "Python",
                table: "CategoriesModel");

            migrationBuilder.DropColumn(
                name: "React",
                table: "CategoriesModel");

            migrationBuilder.RenameColumn(
                name: "Ruby",
                table: "CategoriesModel",
                newName: "CategoryName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "CategoriesModel",
                newName: "Ruby");

            migrationBuilder.AddColumn<string>(
                name: "Android",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Api",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BancoDeDados",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "C",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cloud",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Csharp",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Css",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Html",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Java",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Javascript",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Kotlin",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NodeJs",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Php",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Python",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "React",
                table: "CategoriesModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
