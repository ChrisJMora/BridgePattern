using BridgePatternAPI.Domain.Models;
using BridgePatternAPI.Repositories.Abstractions;
using BridgePatternAPI.Services.Authentication;
using BridgePatternAPI.Services.ModelServices.Abstraction;

namespace BridgePatternAPI.Services.ModelServices.Implementation;

public class DeviceService : IDeviceService
{
    private readonly IDeviceRepo _deviceRepo;
    
    public DeviceService(IDeviceRepo deviceRepo)
    {
        _deviceRepo = deviceRepo;
    }
    
    public async Task<IEnumerable<Device>> GetDevicesAsync()
    {
        return await AuthenticateRepo.AutheticateListAsync(
            functionListAsync: _deviceRepo.GetDevicesAsync
        );
    }
}
