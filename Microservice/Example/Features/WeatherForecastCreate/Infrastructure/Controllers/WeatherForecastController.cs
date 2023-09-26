using Example.Features.WeatherForecastCreate.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ViennaNET.Mediator;
using ViennaNET.Utils;

namespace Example.Features.WeatherForecastCreate.Infrastructure.Controllers
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

    [HttpPost]
    public int Create([FromBody] WeatherForecastForCreate item)
    {
      _mediator.SendMessageAsync(WeatherForecastCreateCommand.Create(item));

      return item.Id;
    }
  }
}