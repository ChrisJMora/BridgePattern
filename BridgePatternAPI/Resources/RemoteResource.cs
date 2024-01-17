using BridgePatternAPI.Domain.Models;

namespace BridgePatternAPI.Resources;

public class RemoteResource : IResource
{
    public string Name { get; set; } = null!;
    public DeviceResource Device { get; set; } = null!;
}
