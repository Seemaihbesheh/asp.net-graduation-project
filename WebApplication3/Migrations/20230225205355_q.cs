using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class q : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Varchar(200)", nullable: false),
                    phoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.id);
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(name: "First_Name", type: "Varchar(Max)", nullable: false),
                    LastName = table.Column<string>(name: "Last_Name", type: "Varchar(200)", nullable: false),
                    phoneNumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(type: "Varchar(max)", nullable: false),
                    UseridComment = table.Column<int>(name: "User_idComment", type: "int", nullable: false),
                    JobpostId = table.Column<int>(name: "Job_postId", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Users_User_idComment",
                        column: x => x.UseridComment,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Varchar(200)", nullable: false),
                    about = table.Column<string>(type: "Varchar(max)", nullable: false),
                    address = table.Column<string>(type: "Varchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<int>(type: "int", nullable: false),
                    services = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyidAccount = table.Column<int>(name: "Company_idAccount", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyAccounts_Users_Company_idAccount",
                        column: x => x.CompanyidAccount,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    UseridCvCreat = table.Column<int>(name: "User_idCv_Creat", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cv_Creats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cv_Creats_Users_User_idCv_Creat",
                        column: x => x.UseridCvCreat,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "notificationss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    notificattext = table.Column<string>(name: "notificat_text", type: "Varchar(max)", nullable: false),
                    Useridnotifications = table.Column<int>(name: "User_idnotifications", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notificationss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_notificationss_Users_User_idnotifications",
                        column: x => x.Useridnotifications,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bio = table.Column<string>(type: "Varchar(max)", nullable: false),
                    city = table.Column<string>(type: "Varchar(max)", nullable: false),
                    Gpa = table.Column<int>(type: "int", nullable: false),
                    cvid = table.Column<int>(name: "cv_id", type: "int", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    UseridAccount = table.Column<int>(name: "User_idAccount", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAccounts_Users_User_idAccount",
                        column: x => x.UseridAccount,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_User_idComment",
                table: "Comments",
                column: "User_idComment");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAccounts_Company_idAccount",
                table: "CompanyAccounts",
                column: "Company_idAccount");

            migrationBuilder.CreateIndex(
                name: "IX_Cv_Creats_User_idCv_Creat",
                table: "Cv_Creats",
                column: "User_idCv_Creat");

            migrationBuilder.CreateIndex(
                name: "IX_notificationss_User_idnotifications",
                table: "notificationss",
                column: "User_idnotifications");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_User_idAccount",
                table: "UserAccounts",
                column: "User_idAccount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "CompanyAccounts");

            migrationBuilder.DropTable(
                name: "Companys");

            migrationBuilder.DropTable(
                name: "Cv_Creats");

            migrationBuilder.DropTable(
                name: "CV_uploads");

            migrationBuilder.DropTable(
                name: "image_posts");

            migrationBuilder.DropTable(
                name: "Jobs_Posts");

            migrationBuilder.DropTable(
                name: "notificationss");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
