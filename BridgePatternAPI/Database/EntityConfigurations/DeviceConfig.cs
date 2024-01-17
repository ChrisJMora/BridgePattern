using BridgePatternAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BridgePatternAPI.Database.EntityConfigurations;

public class DeviceConfig : IEntityTypeConfiguration<Device>
{
    public void Configure(EntityTypeBuilder<Device> builder)
    {
        builder.ToTable("Devices");
        builder.HasKey(x => x.Id);

        builder.HasData(
            new Device { Id = 1, Name = "TV" },
            new Device { Id = 2, Name = "Radio" }
        );
    }
}
