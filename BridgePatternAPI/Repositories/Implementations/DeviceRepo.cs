using BridgePatternAPI.Database;
using BridgePatternAPI.Domain.Models;
using BridgePatternAPI.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace BridgePatternAPI.Repositories.Implementations;

public class DeviceRepo : BaseRepo, IDeviceRepo
{
    public DeviceRepo(AppDbContext context) : base(context) { }
    public async Task<IEnumerable<Device>> GetDevicesAsync()
    {
        return await _context.Devices.ToListAsync();   
    }
}
