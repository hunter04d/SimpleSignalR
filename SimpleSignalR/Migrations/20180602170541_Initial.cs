using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleSignalR.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Owner = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "Owner" },
                values: new object[] { 1, "Cool", "Negev" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Content", "Owner" },
                values: new object[] { 2, "Badio", "Adawg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
