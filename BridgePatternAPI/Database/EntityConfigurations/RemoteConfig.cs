using BridgePatternAPI.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BridgePatternAPI.Database.EntityConfigurations;

public class RemoteConfig : IEntityTypeConfiguration<Remote>
{
    public void Configure(EntityTypeBuilder<Remote> builder)
    {
        builder.ToTable("RemoteControls");
        builder.HasKey(x => x.Id);

        builder.HasOne(e => e.Device).WithOne().HasForeignKey<Remote>(e => e.DeviceId);

        builder.HasData(
            new Remote { Id = 1, Name = "TV Remote", DeviceId = 1 },
            new Remote { Id = 2, Name = "Radio Remote", DeviceId = 2 }
        );
    }
}
