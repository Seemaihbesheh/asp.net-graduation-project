using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class tableupdate8856 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "Users",
                type: "Varchar(Max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(200)");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Varchar(max)", nullable: false),
                    Userid = table.Column<int>(name: "User_id", type: "int", nullable: false),
                    JobpostId = table.Column<int>(name: "Job_postId", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jobs_Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pretitle = table.Column<string>(name: "Pre_title", type: "Varchar(200)", nullable: false),
                    Title = table.Column<string>(type: "Varchar(200)", nullable: false),
                    Companyid = table.Column<string>(name: "Company_id", type: "nvarchar(max)", nullable: false),
                    Requrment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDeadline = table.Column<int>(name: "Job_Deadline", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs_Posts", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Jobs_Posts");

            migrationBuilder.AlterColumn<string>(
                name: "First_Name",
                table: "Users",
                type: "Varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(Max)");
        }
    }
}
