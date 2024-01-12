using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym_Bobescu.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AntrenorID",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Antrenor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeAntrenor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antrenor", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_AntrenorID",
                table: "Client",
                column: "AntrenorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Antrenor_AntrenorID",
                table: "Client",
                column: "AntrenorID",
                principalTable: "Antrenor",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Antrenor_AntrenorID",
                table: "Client");

            migrationBuilder.DropTable(
                name: "Antrenor");

            migrationBuilder.DropIndex(
                name: "IX_Client_AntrenorID",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "AntrenorID",
                table: "Client");
        }
    }
}
