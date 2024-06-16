using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CLEANASPNETRestaurant.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CaloriesPerKiloAddedToDish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaloriesPerKilo",
                table: "Dishes",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaloriesPerKilo",
                table: "Dishes");
        }
    }
}
