﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.DBContext;

#nullable disable

namespace WebApplication3.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230223104113_seeee")]
    partial class seeee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication3.DBContext.CV_upload", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("type");

                    b.HasKey("id");

                    b.ToTable("CV_uploads");
                });

            modelBuilder.Entity("WebApplication3.DBContext.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("Name");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("WebApplication3.DBContext.CompanyAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Company_id")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("Name");

                    b.Property<string>("about")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("about");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("address");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("services")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyAccounts");
                });

            modelBuilder.Entity("WebApplication3.DBContext.Cv_Creat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AboutMe")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("AboutMe");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceYear")
                        .HasColumnType("int");

                    b.Property<int>("Gpa")
                        .HasColumnType("int");

                    b.Property<string>("Languages")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("Skills");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cv_Creats");
                });

            modelBuilder.Entity("WebApplication3.DBContext.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("First_Name");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("Last_Name");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication3.DBContext.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<int>("Gpa")
                        .HasColumnType("int");

                    b.Property<bool>("State")
                        .HasColumnType("bit");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<string>("bio")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("bio");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("city");

                    b.Property<int>("cv_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("WebApplication3.DBContext.image_post", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("image_file")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("image_file");

                    b.Property<string>("image_name")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("image_name");

                    b.Property<string>("image_type")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("image_type");

                    b.HasKey("id");

                    b.ToTable("image_posts");
                });

            modelBuilder.Entity("WebApplication3.DBContext.notifications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<string>("notificat_text")
                        .IsRequired()
                        .HasColumnType("Varchar(max)")
                        .HasColumnName("notificat_text");

                    b.HasKey("Id");

                    b.ToTable("notificationss");
                });
#pragma warning restore 612, 618
        }
    }
}
