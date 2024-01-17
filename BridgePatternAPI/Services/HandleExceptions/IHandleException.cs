using BridgePatternAPI.Domain.Models;
using BridgePatternAPI.Resources;
using Microsoft.AspNetCore.Mvc;

namespace BridgePatternAPI.Services.HandleExceptions;

public interface IHandleException
{
    Task<IActionResult>
     HandleExceptionAsync<T, TResult>(Func<Task<T>> functionAsync) 
     where T : IModel where TResult : IResource;

    Task<IActionResult>
     HandleExceptionAsync<T, TResult>(Func<Task<IEnumerable<T>>> functionAsync) 
     where T : IModel where TResult : IResource;
}
