using BridgePatternAPI.Domain.Models;

namespace BridgePatternAPI.Services.ModelServices.Abstraction;

public interface IDeviceService
{
    public Task<IEnumerable<Device>> GetDevicesAsync();
}
