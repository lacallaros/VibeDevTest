using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VibeDevTest.Migrations
{
    public partial class PartMaterialRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Material",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceMultiplier = table.Column<float>(type: "real", nullable: false),
                    PartsStockId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Material_PartsStocks_PartsStockId",
                        column: x => x.PartsStockId,
                        principalTable: "PartsStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Material_PartsStockId",
                table: "Material",
                column: "PartsStockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Material");
        }
    }
}
