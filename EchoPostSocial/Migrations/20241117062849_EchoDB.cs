using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoPostSocial.Migrations
{
    public partial class EchoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.userId);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "userId", "password", "userName" },
                values: new object[] { 1, "password", "example" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "userId", "password", "userName" },
                values: new object[] { 2, "password1", "example1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
