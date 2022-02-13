using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDCompanionWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoginModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDungeonMaster = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "LoginModels",
                columns: new[] { "Id", "IsDungeonMaster", "Password", "UserName" },
                values: new object[] { 1, true, "password", "dm" });

            migrationBuilder.InsertData(
                table: "LoginModels",
                columns: new[] { "Id", "IsDungeonMaster", "Password", "UserName" },
                values: new object[] { 2, false, "password", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginModels");
        }
    }
}
