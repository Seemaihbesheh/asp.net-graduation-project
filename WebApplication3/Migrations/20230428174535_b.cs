using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_User_idComment",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Cv_Creats_Users_User_idCv_Creat",
                table: "Cv_Creats");

            migrationBuilder.DropForeignKey(
                name: "FK_notificationss_Users_User_idnotifications",
                table: "notificationss");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_notificationss_User_idnotifications",
                table: "notificationss");

            migrationBuilder.DropIndex(
                name: "IX_Cv_Creats_User_idCv_Creat",
                table: "Cv_Creats");

            migrationBuilder.DropIndex(
                name: "IX_Comments_User_idComment",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "User_id",
                table: "CV_uploads");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "User_id",
                table: "CV_uploads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(name: "First_Name", type: "Varchar(Max)", nullable: false),
                    GPA = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(name: "Last_Name", type: "Varchar(200)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_notificationss_User_idnotifications",
                table: "notificationss",
                column: "User_idnotifications");

            migrationBuilder.CreateIndex(
                name: "IX_Cv_Creats_User_idCv_Creat",
                table: "Cv_Creats",
                column: "User_idCv_Creat");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_User_idComment",
                table: "Comments",
                column: "User_idComment");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_User_idComment",
                table: "Comments",
                column: "User_idComment",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cv_Creats_Users_User_idCv_Creat",
                table: "Cv_Creats",
                column: "User_idCv_Creat",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_notificationss_Users_User_idnotifications",
                table: "notificationss",
                column: "User_idnotifications",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
