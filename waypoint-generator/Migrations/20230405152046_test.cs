using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace waypoint_generator.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalibrationPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    CalibrationPlanType = table.Column<string>(type: "TEXT", nullable: false),
                    StartAzimuth = table.Column<double>(type: "REAL", nullable: true),
                    StepAzimuth = table.Column<double>(type: "REAL", nullable: true),
                    StopAzimuth = table.Column<double>(type: "REAL", nullable: true),
                    StartElevation = table.Column<double>(type: "REAL", nullable: true),
                    StepElevation = table.Column<double>(type: "REAL", nullable: true),
                    StopElevation = table.Column<double>(type: "REAL", nullable: true),
                    Buffer = table.Column<double>(type: "REAL", nullable: true),
                    Radius = table.Column<double>(type: "REAL", nullable: true),
                    Speed = table.Column<double>(type: "REAL", nullable: true),
                    Duration = table.Column<int>(type: "INTEGER", nullable: true),
                    OffsetAzimuth = table.Column<float>(type: "REAL", nullable: true),
                    OffsetElevation = table.Column<float>(type: "REAL", nullable: true),
                    RollAlignmentPlan_Radius = table.Column<float>(type: "REAL", nullable: true),
                    Zenith = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalibrationPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScanPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    ScanPlanType = table.Column<string>(type: "TEXT", nullable: false),
                    Start = table.Column<double>(type: "REAL", nullable: true),
                    Step = table.Column<double>(type: "REAL", nullable: true),
                    Stop = table.Column<double>(type: "REAL", nullable: true),
                    Speed = table.Column<double>(type: "REAL", nullable: true),
                    Radius = table.Column<double>(type: "REAL", nullable: true),
                    Roll = table.Column<double>(type: "REAL", nullable: true),
                    AzimuthStart = table.Column<double>(type: "REAL", nullable: true),
                    AzimuthStep = table.Column<double>(type: "REAL", nullable: true),
                    AzimuthStop = table.Column<double>(type: "REAL", nullable: true),
                    ElevationStart = table.Column<double>(type: "REAL", nullable: true),
                    ElevationStep = table.Column<double>(type: "REAL", nullable: true),
                    ElevationStop = table.Column<double>(type: "REAL", nullable: true),
                    RasterPlan_Speed = table.Column<double>(type: "REAL", nullable: true),
                    RasterPlan_Radius = table.Column<double>(type: "REAL", nullable: true),
                    Duration = table.Column<double>(type: "REAL", nullable: true),
                    OffsetAzimuth = table.Column<double>(type: "REAL", nullable: true),
                    OffsetElevation = table.Column<double>(type: "REAL", nullable: true),
                    SinglePointPlan_Radius = table.Column<double>(type: "REAL", nullable: true),
                    Polarization = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScanPlans", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalibrationPlans");

            migrationBuilder.DropTable(
                name: "ScanPlans");
        }
    }
}
