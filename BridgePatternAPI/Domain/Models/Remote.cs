namespace BridgePatternAPI.Domain.Models;

public class Remote : IModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int DeviceId { get; set; }
    public Device Device { get; set; } = null!;
}
