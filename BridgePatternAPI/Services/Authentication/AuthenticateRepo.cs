using BridgePatternAPI.Domain.Models;

namespace BridgePatternAPI.Services.Authentication;

public class AuthenticateRepo
{
    public static async Task<IEnumerable<T>>
     AutheticateListAsync<T>(Func<Task<IEnumerable<T>>> functionListAsync) where T : IModel
     {

        var list = await functionListAsync();
        if (!list.Any())
        throw new Exception("No data found");
        return list;
    }
}
