using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class tableupda5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccount",
                table: "UserAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserAccount");

            migrationBuilder.DropColumn(
                name: "First_Name",
                table: "UserAccount");

            migrationBuilder.DropColumn(
                name: "Last_Name",
                table: "UserAccount");

            migrationBuilder.RenameTable(
                name: "UserAccount",
                newName: "UserAccounts");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "UserAccounts",
                newName: "cv_id");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "UserAccounts",
                newName: "University");

            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "UserAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Gpa",
                table: "UserAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "State",
                table: "UserAccounts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "User_id",
                table: "UserAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "bio",
                table: "UserAccounts",
                type: "Varchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "UserAccounts",
                type: "Varchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Cv_Creats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutMe = table.Column<string>(type: "Varchar(max)", nullable: false),
                    Skills = table.Column<string>(type: "Varchar(max)", nullable: false),
                    Languages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gpa = table.Column<int>(type: "int", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceYear = table.Column<int>(type: "int", nullable: false),
                    Userid = table.Column<int>(name: "User_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cv_Creats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CV_uploads",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "Varchar(max)", nullable: false),
                    type = table.Column<string>(type: "Varchar(max)", nullable: false),
                    Userid = table.Column<int>(name: "User_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CV_uploads", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cv_Creats");

            migrationBuilder.DropTable(
                name: "CV_uploads");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "Gpa",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "State",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "User_id",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "bio",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "city",
                table: "UserAccounts");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "UserAccounts",
                newName: "UserAccount");

            migrationBuilder.RenameColumn(
                name: "cv_id",
                table: "UserAccount",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "University",
                table: "UserAccount",
                newName: "password");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserAccount",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "First_Name",
                table: "UserAccount",
                type: "Varchar(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Last_Name",
                table: "UserAccount",
                type: "Varchar(200)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccount",
                table: "UserAccount",
                column: "Id");
        }
    }
}
