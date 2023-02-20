using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupermarketConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class manhs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Xaridlarid",
                table: "Mahsulotlar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Xaridlar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vaqti = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xaridlar", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mahsulotlar_Xaridlarid",
                table: "Mahsulotlar",
                column: "Xaridlarid");

            migrationBuilder.AddForeignKey(
                name: "FK_Mahsulotlar_Xaridlar_Xaridlarid",
                table: "Mahsulotlar",
                column: "Xaridlarid",
                principalTable: "Xaridlar",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mahsulotlar_Xaridlar_Xaridlarid",
                table: "Mahsulotlar");

            migrationBuilder.DropTable(
                name: "Xaridlar");

            migrationBuilder.DropIndex(
                name: "IX_Mahsulotlar_Xaridlarid",
                table: "Mahsulotlar");

            migrationBuilder.DropColumn(
                name: "Xaridlarid",
                table: "Mahsulotlar");
        }
    }
}
