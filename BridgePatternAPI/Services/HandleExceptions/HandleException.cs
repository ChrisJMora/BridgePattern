using AutoMapper;
using BridgePatternAPI.Domain.Models;
using BridgePatternAPI.Resources;
using Microsoft.AspNetCore.Mvc;

namespace BridgePatternAPI.Services.HandleExceptions;

public class HandleException : ControllerBase, IHandleException
{
    private readonly IMapper _mapper = null!;

    public HandleException(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<IActionResult>
     HandleExceptionAsync<T, TResult>(Func<Task<T>> functionAsync) 
     where T : IModel where TResult : IResource
    {
        try
        {
            var entity = await functionAsync();
            return Ok(_mapper.Map<T, TResult>(entity));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    public async Task<IActionResult>
     HandleExceptionAsync<T, TResult>(Func<Task<IEnumerable<T>>> functionAsync) 
     where T : IModel where TResult : IResource
    {
        try
        {
            var collection = await functionAsync();
            return Ok(_mapper.Map<IEnumerable<T>, IEnumerable<TResult>>(collection));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
