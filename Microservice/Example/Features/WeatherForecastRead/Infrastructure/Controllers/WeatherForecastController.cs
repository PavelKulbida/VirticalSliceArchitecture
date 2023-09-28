using System.Diagnostics.CodeAnalysis;
using Example.Features.WeatherForecastRead.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ViennaNET.Mediator;
using ViennaNET.Utils;

namespace Example.Features.WeatherForecastRead.Infrastructure.Controllers
{
  [ApiController]
  [Route("[controller]")]
  [ExcludeFromCodeCoverage]
  public class WeatherForecastController : ControllerBase
  {
    private readonly IMediator _mediator;

    public WeatherForecastController(IMediator mediator)
    {
      _mediator = mediator.ThrowIfNull(nameof(mediator));
    }

    [HttpGet("{id:int}")]
    [AllowAnonymous]
    public WeatherForecastForRead? Read(int id)
    {
      return _mediator.SendMessage<GetWeatherForecastRequest, WeatherForecastForRead>(
        GetWeatherForecastRequest.Create(id));
    }
  }
}