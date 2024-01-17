using BridgePatternAPI.Domain.Models;

namespace BridgePatternAPI.Repositories.Abstractions;

public interface IRemoteRepo
{
    public Task<IEnumerable<Remote>> GetRemotesAsync();
}
