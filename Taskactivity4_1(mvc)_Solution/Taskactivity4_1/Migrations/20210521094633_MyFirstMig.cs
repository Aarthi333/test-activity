using Microsoft.EntityFrameworkCore.Migrations;

namespace Taskactivity4_1.Migrations
{
    public partial class MyFirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Profile_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmployed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoticePeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentCTC = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Profile_Id);
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Profile_Id", "Age", "CurrentCTC", "IsEmployed", "Name", "NoticePeriod", "Qualification" },
                values: new object[] { 1, 30, 30000f, "YES", "Ramu", "2", "BSC" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
