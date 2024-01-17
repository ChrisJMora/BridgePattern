using BridgePatternAPI.Domain.Models;

namespace BridgePatternAPI.Repositories.Abstractions;

public interface IDeviceRepo
{
    public Task<IEnumerable<Device>> GetDevicesAsync();
}
