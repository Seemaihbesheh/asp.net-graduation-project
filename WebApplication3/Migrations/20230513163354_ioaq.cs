using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class ioaq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "skillName",
                table: "skills",
                newName: "skilltwo");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "projects",
                newName: "Titletwo");

            migrationBuilder.RenameColumn(
                name: "Decription",
                table: "projects",
                newName: "Titleone");

            migrationBuilder.AddColumn<string>(
                name: "skillone",
                table: "skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "skillthree",
                table: "skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Decriptionone",
                table: "projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Decriptiontwo",
                table: "projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "skillone",
                table: "skills");

            migrationBuilder.DropColumn(
                name: "skillthree",
                table: "skills");

            migrationBuilder.DropColumn(
                name: "Decriptionone",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "Decriptiontwo",
                table: "projects");

            migrationBuilder.RenameColumn(
                name: "skilltwo",
                table: "skills",
                newName: "skillName");

            migrationBuilder.RenameColumn(
                name: "Titletwo",
                table: "projects",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Titleone",
                table: "projects",
                newName: "Decription");
        }
    }
}
