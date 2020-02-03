using Microsoft.EntityFrameworkCore.Migrations;

namespace Atomlista.Migrations
{
    public partial class UniqueUsernameForPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_People_Username",
                table: "People",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_People_Username",
                table: "People");
        }
    }
}
