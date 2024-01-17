using BridgePatternAPI.Domain.Models;

namespace BridgePatternAPI.Services.ModelServices.Abstraction;

public interface IRemoteService
{
    public Task<IEnumerable<Remote>> GetRemotesAsync();
}
