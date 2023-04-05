using Microsoft.EntityFrameworkCore;
using System.Reflection;

public class DataContext : DbContext
{
    public DbSet<SinglePoint> SinglePointPlans { get; set; }
    public DbSet<Principal> PrincipalPlans { get; set; }
    public DbSet<Raster> RasterPlans { get; set; }


    public DbSet<RollAlignment> RollAlignmentPlans { get; set; }
    public DbSet<BeamFinding> BeamFindingPlans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"DataSource=mydatabase.db;");
    //options.UseNpgsql("Host=postgres; Database=missions; Username=postgres; Password=postgres");

}