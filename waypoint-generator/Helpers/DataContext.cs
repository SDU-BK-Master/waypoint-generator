using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{


    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseNpgsql("Host = localhost; Database=test; Username=postgres; Password=123456");
}