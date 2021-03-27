using Microsoft.EntityFrameworkCore.Migrations;

namespace BazaPoklona.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OstvareniPrometViewModels",
                columns: table => new
                {
                    NazivRobe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VrstaRobe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UkupnoLovePoVrstiRobe = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "VrstaRobe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaRobe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Poklon",
                columns: table => new
                {
                    IdPoklon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    VrstaRobe = table.Column<int>(type: "int", nullable: false),
                    Kupljen = table.Column<bool>(type: "bit", nullable: false),
                    Cijena = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Poklon__2D443D4D5AEE092A", x => x.IdPoklon);
                    table.ForeignKey(
                        name: "FK__Poklon__VrstaRob__286302EC",
                        column: x => x.VrstaRobe,
                        principalTable: "VrstaRobe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trgovina",
                columns: table => new
                {
                    IdTrgovina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivTrgovina = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    VrstaRobe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Trgovina__A41276705583ABF8", x => x.IdTrgovina);
                    table.ForeignKey(
                        name: "FK__Trgovina__VrstaR__29572725",
                        column: x => x.VrstaRobe,
                        principalTable: "VrstaRobe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Poklon_VrstaRobe",
                table: "Poklon",
                column: "VrstaRobe");

            migrationBuilder.CreateIndex(
                name: "IX_Trgovina_VrstaRobe",
                table: "Trgovina",
                column: "VrstaRobe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OstvareniPrometViewModels");

            migrationBuilder.DropTable(
                name: "Poklon");

            migrationBuilder.DropTable(
                name: "Trgovina");

            migrationBuilder.DropTable(
                name: "VrstaRobe");
        }
    }
}
