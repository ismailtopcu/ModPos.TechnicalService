using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModPos.TechnicalService.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_initial_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ServiceTotalAmount",
                table: "Services",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ServiceLineAmount",
                table: "ServiceMovements",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceTotalAmount",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ServiceLineAmount",
                table: "ServiceMovements");
        }
    }
}
