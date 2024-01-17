namespace BridgePatternAPI.Domain.Models;

public class Device : IModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}
