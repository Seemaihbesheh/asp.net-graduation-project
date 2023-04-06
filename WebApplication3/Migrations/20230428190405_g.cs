using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class g : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "services",
                table: "Companys",
                newName: "services_title");

            migrationBuilder.AddColumn<string>(
                name: "services_about",
                table: "Companys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "services_about",
                table: "Companys");

            migrationBuilder.RenameColumn(
                name: "services_title",
                table: "Companys",
                newName: "services");
        }
    }
}
