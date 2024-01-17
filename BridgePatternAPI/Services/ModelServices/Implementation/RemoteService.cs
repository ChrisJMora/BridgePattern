using BridgePatternAPI.Domain.Models;
using BridgePatternAPI.Repositories.Abstractions;
using BridgePatternAPI.Resources;
using BridgePatternAPI.Services.Authentication;
using BridgePatternAPI.Services.ModelServices.Abstraction;

namespace BridgePatternAPI.Services.ModelServices.Implementation;

public class RemoteService : IRemoteService
{
    private readonly IRemoteRepo _remoteRepo;
    private readonly IDeviceRepo _deviceRepo;
    
    public RemoteService(IRemoteRepo remoteRepo, IDeviceRepo deviceRepo)
    {
        _remoteRepo = remoteRepo;
        _deviceRepo = deviceRepo;
    }
    
    private async Task<IEnumerable<Remote>> InnerJoin()
    {
        return from device in await _deviceRepo.GetDevicesAsync()
            join remote in await _remoteRepo.GetRemotesAsync()
            on device.Id equals remote.DeviceId
            select new Remote
            {
                Id = remote.Id,
                Name = remote.Name,
                DeviceId = remote.DeviceId,
                Device = device
            };
    }

    public async Task<IEnumerable<Remote>> GetRemotesAsync()
    {
        return await AuthenticateRepo.AutheticateListAsync(
            functionListAsync: InnerJoin
        );
    }
}