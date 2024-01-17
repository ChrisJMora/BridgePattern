using BridgePatternAPI.Database.EntityConfigurations;
using BridgePatternAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BridgePatternAPI.Database;

public class AppDbContext : DbContext
{
    public DbSet<Device> Devices { get; set; }
    public DbSet<Remote> RemoteControls { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        new DeviceConfig().Configure(builder.Entity<Device>());
        new RemoteConfig().Configure(builder.Entity<Remote>());
    }
}
