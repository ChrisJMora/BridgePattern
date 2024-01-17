using BridgePatternAPI.Domain.Models;
using BridgePatternAPI.Resources;
using BridgePatternAPI.Services.HandleExceptions;
using BridgePatternAPI.Services.ModelServices.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace BridgePatternAPI.Controllers;

[Route("api/[Controller]")]
public class DeviceController(
    IDeviceService deviceService,
    IHandleException handleException
    ) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetDevices()
    {
        return await handleException.HandleExceptionAsync<Device, DeviceResource>(
            functionAsync: deviceService.GetDevicesAsync
        );
    }
}
