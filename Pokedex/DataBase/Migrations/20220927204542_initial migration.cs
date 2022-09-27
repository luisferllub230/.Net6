using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBase.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonRegions",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemonRegionsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonRegions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TypesPokemons",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesPokemons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pokemonImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pokemonRegionId = table.Column<int>(type: "int", nullable: false),
                    TypePrimaryPokemonId = table.Column<int>(type: "int", nullable: false),
                    TypeSecondaryPokemonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pokemons_PokemonRegions_pokemonRegionId",
                        column: x => x.pokemonRegionId,
                        principalTable: "PokemonRegions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemons_TypesPokemons_TypePrimaryPokemonId",
                        column: x => x.TypePrimaryPokemonId,
                        principalTable: "TypesPokemons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_pokemonRegionId",
                table: "Pokemons",
                column: "pokemonRegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TypePrimaryPokemonId",
                table: "Pokemons",
                column: "TypePrimaryPokemonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "PokemonRegions");

            migrationBuilder.DropTable(
                name: "TypesPokemons");
        }
    }
}
