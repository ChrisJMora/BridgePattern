using AutoMapper;
using BridgePatternAPI.Domain.Models;
using BridgePatternAPI.Resources;

namespace BridgePatternAPI.Mapping;

public class ModelToResource : Profile
{
    public ModelToResource()
    {
        CreateMap<Device, DeviceResource>();
        CreateMap<Remote, RemoteResource>();
    }
}
