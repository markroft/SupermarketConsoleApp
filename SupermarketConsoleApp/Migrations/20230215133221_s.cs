using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupermarketConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class s : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FIO",
                table: "Ishchilar",
                newName: "password");

            migrationBuilder.AddColumn<string>(
                name: "UserFirstName",
                table: "Ishchilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserLastName",
                table: "Ishchilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "login",
                table: "Ishchilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserFirstName",
                table: "Ishchilar");

            migrationBuilder.DropColumn(
                name: "UserLastName",
                table: "Ishchilar");

            migrationBuilder.DropColumn(
                name: "login",
                table: "Ishchilar");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Ishchilar",
                newName: "FIO");
        }
    }
}
