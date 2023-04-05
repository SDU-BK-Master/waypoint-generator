using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace waypoint_generator.Migrations
{
    /// <inheritdoc />
    public partial class new_columns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Direction",
                table: "ScanPlans",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Plane",
                table: "ScanPlans",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RasterPlan_Direction",
                table: "ScanPlans",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RasterPlan_Plane",
                table: "ScanPlans",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RasterPlan_Polarization",
                table: "ScanPlans",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SinglePointPlan_Polarization",
                table: "ScanPlans",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direction",
                table: "ScanPlans");

            migrationBuilder.DropColumn(
                name: "Plane",
                table: "ScanPlans");

            migrationBuilder.DropColumn(
                name: "RasterPlan_Direction",
                table: "ScanPlans");

            migrationBuilder.DropColumn(
                name: "RasterPlan_Plane",
                table: "ScanPlans");

            migrationBuilder.DropColumn(
                name: "RasterPlan_Polarization",
                table: "ScanPlans");

            migrationBuilder.DropColumn(
                name: "SinglePointPlan_Polarization",
                table: "ScanPlans");
        }
    }
}
