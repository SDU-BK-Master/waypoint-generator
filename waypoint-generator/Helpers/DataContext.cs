using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
public class DataContext : DbContext
{
    public DbSet<BaseScanPlan> ScanPlans { get; set; }
    public DbSet<BaseCalibrationPlan> CalibrationPlans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
=> options.UseSqlite(@"DataSource=mydatabase.db;");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure TPH mapping for BaseScanPlan
        modelBuilder.Entity<BaseScanPlan>(entity =>
        {
            entity.ToTable("ScanPlans");
            entity.HasDiscriminator<string>("ScanPlanType")
                .HasValue<PrincipalPlan>("Principal")
                .HasValue<RasterPlan>("Raster")
                .HasValue<SinglePointPlan>("SinglePoint");
        });

        // Configure TPH mapping for BaseCalibrationPlan
        modelBuilder.Entity<BaseCalibrationPlan>(entity =>
        {
            entity.ToTable("CalibrationPlans");
            entity.HasDiscriminator<string>("CalibrationPlanType")
                .HasValue<BeamFindingPlan>("BeamFinding")
                .HasValue<RollAlignmentPlan>("RollAlignment");
        });
    }

}