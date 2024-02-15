using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class ioaquuiajss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titleone",
                table: "projects",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Decriptionone",
                table: "projects",
                newName: "Decription");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "projects",
                newName: "Titleone");

            migrationBuilder.RenameColumn(
                name: "Decription",
                table: "projects",
                newName: "Decriptionone");
        }
    }
}
