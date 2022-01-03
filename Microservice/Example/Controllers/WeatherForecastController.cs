using Example.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private readonly ServiceDbContext _dbContext = new ServiceDbContext();

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
      return _dbContext.WeatherForecast;
    }

    [HttpPost(Name = "GetWeatherForecast")]
    public void Post(WeatherForecast item)
    {
      _dbContext.WeatherForecast.Add(item);
      _dbContext.SaveChanges();
    }
  }
}