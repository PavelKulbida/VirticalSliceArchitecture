using System.Diagnostics.CodeAnalysis;
using Example.Features.WeatherForecastCreate.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ViennaNET.Mediator;
using ViennaNET.Utils;

namespace Example.Features.WeatherForecastCreate.Infrastructure.Controllers
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

    [HttpPost]
    [AllowAnonymous]
    public int Create([FromBody] WeatherForecast item)
    {
      _mediator.SendMessage(WeatherForecastCreateCommand.Create(item));

      return item.Id;
    }
  }
}