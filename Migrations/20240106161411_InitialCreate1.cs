using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym_Bobescu.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Varsta",
                table: "Client",
                newName: "Greutate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Greutate",
                table: "Client",
                newName: "Varsta");
        }
    }
}
