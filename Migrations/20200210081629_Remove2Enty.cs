using Microsoft.EntityFrameworkCore.Migrations;

namespace Atomlista.Migrations
{
    public partial class Remove2Enty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atoms_BusinessOwners_BusinessOwnerId",
                table: "Atoms");

            migrationBuilder.DropForeignKey(
                name: "FK_Atoms_TechOwners_TechOwnerId",
                table: "Atoms");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_BusinessOwners_BusinessOwnerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TechOwners_TechOwnerId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "BusinessOwners");

            migrationBuilder.DropTable(
                name: "TechOwners");

            migrationBuilder.DropIndex(
                name: "IX_Products_BusinessOwnerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Atoms_BusinessOwnerId",
                table: "Atoms");

            migrationBuilder.DropColumn(
                name: "BusinessOwnerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BusinessOwnerId",
                table: "Atoms");

            migrationBuilder.AddColumn<int>(
                name: "BussinessOwnerId",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BussinessOwnerId",
                table: "Atoms",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BussinessOwnerId",
                table: "Products",
                column: "BussinessOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Atoms_BussinessOwnerId",
                table: "Atoms",
                column: "BussinessOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atoms_People_BussinessOwnerId",
                table: "Atoms",
                column: "BussinessOwnerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Atoms_People_TechOwnerId",
                table: "Atoms",
                column: "TechOwnerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_People_BussinessOwnerId",
                table: "Products",
                column: "BussinessOwnerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_People_TechOwnerId",
                table: "Products",
                column: "TechOwnerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atoms_People_BussinessOwnerId",
                table: "Atoms");

            migrationBuilder.DropForeignKey(
                name: "FK_Atoms_People_TechOwnerId",
                table: "Atoms");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_People_BussinessOwnerId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_People_TechOwnerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_BussinessOwnerId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Atoms_BussinessOwnerId",
                table: "Atoms");

            migrationBuilder.DropColumn(
                name: "BussinessOwnerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BussinessOwnerId",
                table: "Atoms");

            migrationBuilder.AddColumn<int>(
                name: "BusinessOwnerId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BusinessOwnerId",
                table: "Atoms",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BusinessOwners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessOwners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessOwners_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechOwners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechOwners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TechOwners_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BusinessOwnerId",
                table: "Products",
                column: "BusinessOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Atoms_BusinessOwnerId",
                table: "Atoms",
                column: "BusinessOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessOwners_PersonId",
                table: "BusinessOwners",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_TechOwners_PersonId",
                table: "TechOwners",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atoms_BusinessOwners_BusinessOwnerId",
                table: "Atoms",
                column: "BusinessOwnerId",
                principalTable: "BusinessOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Atoms_TechOwners_TechOwnerId",
                table: "Atoms",
                column: "TechOwnerId",
                principalTable: "TechOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BusinessOwners_BusinessOwnerId",
                table: "Products",
                column: "BusinessOwnerId",
                principalTable: "BusinessOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TechOwners_TechOwnerId",
                table: "Products",
                column: "TechOwnerId",
                principalTable: "TechOwners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
