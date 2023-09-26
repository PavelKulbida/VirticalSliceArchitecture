using Example.Features.WeatherForecastBrowse.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ViennaNET.Mediator;
using ViennaNET.Utils;

namespace Example.Features.WeatherForecastBrowse.Infrastructure.Controllers
{
  [ApiController]
  [AllowAnonymous]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private readonly IMediator _mediator;

    public WeatherForecastController(IMediator mediator)
    {
      _mediator = mediator.ThrowIfNull(nameof(mediator));
    }

    [HttpGet]
    public IEnumerable<WeatherForecastForBrowse> ReadAll()
    {
      return _mediator.SendMessage<GetAllWeatherForecastRequest, IEnumerable<WeatherForecastForBrowse>>(
        GetAllWeatherForecastRequest.Create());
    }
  }
}