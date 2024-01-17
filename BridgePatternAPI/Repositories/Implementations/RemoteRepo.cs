using BridgePatternAPI.Database;
using BridgePatternAPI.Domain.Models;
using BridgePatternAPI.Repositories.Abstractions;
using BridgePatternAPI.Repositories.Implementations;
using Microsoft.EntityFrameworkCore;

namespace BridgePatternAPI;

public class RemoteRepo : BaseRepo, IRemoteRepo
{
    public RemoteRepo(AppDbContext context) : base(context) { }

    public async Task<IEnumerable<Remote>> GetRemotesAsync()
    {
        return await _context.RemoteControls.ToListAsync();
    }
}
