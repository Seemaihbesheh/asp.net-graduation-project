using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class eetjuqsq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_userUs_useruid",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_useruid",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "useruid",
                table: "Product");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "useruid",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_useruid",
                table: "Product",
                column: "useruid");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_userUs_useruid",
                table: "Product",
                column: "useruid",
                principalTable: "userUs",
                principalColumn: "Id");
        }
    }
}
