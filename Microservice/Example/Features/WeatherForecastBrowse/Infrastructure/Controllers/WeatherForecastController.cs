using System.Diagnostics.CodeAnalysis;
using Example.Features.WeatherForecastBrowse.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ViennaNET.Mediator;
using ViennaNET.Utils;

namespace Example.Features.WeatherForecastBrowse.Infrastructure.Controllers
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

    [HttpGet]
    [AllowAnonymous]
    public IEnumerable<WeatherForecast> ReadAll()
    {
      return _mediator.SendMessage<GetAllWeatherForecastRequest, IEnumerable<WeatherForecast>>(
        GetAllWeatherForecastRequest.Create());
    }
  }
}