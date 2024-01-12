using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym_Bobescu.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalaID",
                table: "Antrenor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sala",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeSala = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Strada = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Antrenor_SalaID",
                table: "Antrenor",
                column: "SalaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Antrenor_Sala_SalaID",
                table: "Antrenor",
                column: "SalaID",
                principalTable: "Sala",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Antrenor_Sala_SalaID",
                table: "Antrenor");

            migrationBuilder.DropTable(
                name: "Sala");

            migrationBuilder.DropIndex(
                name: "IX_Antrenor_SalaID",
                table: "Antrenor");

            migrationBuilder.DropColumn(
                name: "SalaID",
                table: "Antrenor");
        }
    }
}
