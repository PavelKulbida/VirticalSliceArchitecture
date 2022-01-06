using Example.Features.WeatherForecastRead.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace Example.Features.WeatherForecastRead.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private readonly WeatherForecastReadDbContext _dbContext;

    public WeatherForecastController(WeatherForecastReadDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    [HttpGet("{id:int}")]
    public WeatherForecastForRead? Read(int id)
    {
      return _dbContext
        .WeatherForecast
        .SingleOrDefault(x => x.Id == id);
    }
  }
}