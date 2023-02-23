using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class seee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "image_posts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imagename = table.Column<string>(name: "image_name", type: "Varchar(max)", nullable: false),
                    imagefile = table.Column<string>(name: "image_file", type: "Varchar(max)", nullable: false),
                    imagetype = table.Column<string>(name: "image_type", type: "Varchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_image_posts", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "image_posts");
        }
    }
}
