using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    Role_Name = table.Column<string>(maxLength: 100, nullable: true),
                    Role_Title = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    User_Image = table.Column<string>(maxLength: 150, nullable: true),
                    User_Email = table.Column<string>(maxLength: 100, nullable: true),
                    User_Password = table.Column<string>(maxLength: 100, nullable: true),
                    User_Password_Disposable = table.Column<string>(maxLength: 100, nullable: true),
                    User_FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    User_LastName = table.Column<string>(maxLength: 100, nullable: true),
                    User_Address = table.Column<string>(maxLength: 500, nullable: true),
                    User_Mobile = table.Column<string>(maxLength: 50, nullable: true),
                    User_EmailActiveCode = table.Column<string>(maxLength: 100, nullable: true),
                    User_IsActivated = table.Column<bool>(nullable: false),
                    User_LastLoginDate = table.Column<DateTimeOffset>(nullable: true),
                    User_CodeActivate = table.Column<string>(nullable: true),
                    IsAdmin = table.Column<bool>(nullable: false),
                    Role_number = table.Column<int>(nullable: false),
                    BuyerType = table.Column<int>(nullable: false),
                    User_PostalCode = table.Column<string>(maxLength: 50, nullable: true),
                    User_Cityname = table.Column<string>(nullable: true),
                    User_Provinces = table.Column<int>(nullable: false),
                    User_Gender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
