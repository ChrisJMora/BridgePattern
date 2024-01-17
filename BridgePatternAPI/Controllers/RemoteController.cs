using BridgePatternAPI.Domain.Models;
using BridgePatternAPI.Resources;
using BridgePatternAPI.Services.HandleExceptions;
using BridgePatternAPI.Services.ModelServices.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace BridgePatternAPI.Controllers;

[Route("api/[Controller]")]
public class RemoteController(
    IRemoteService remoteService,
    IHandleException handleException
) : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetRemotes()
    {
        return await handleException.HandleExceptionAsync<Remote, RemoteResource>(
            functionAsync: remoteService.GetRemotesAsync
        );
    }
}