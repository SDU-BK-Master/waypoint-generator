using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace waypoint_generator.Migrations
{
    /// <inheritdoc />
    public partial class new_columns2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MissionID",
                table: "ScanPlans",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MissionID",
                table: "CalibrationPlans",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MissionID",
                table: "ScanPlans");

            migrationBuilder.DropColumn(
                name: "MissionID",
                table: "CalibrationPlans");
        }
    }
}
