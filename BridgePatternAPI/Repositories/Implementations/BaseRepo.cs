using BridgePatternAPI.Database;

namespace BridgePatternAPI.Repositories.Implementations;

public class BaseRepo
{
    protected AppDbContext _context { get; set; }
    public BaseRepo(AppDbContext context)
    {
        _context = context;
    }
}
