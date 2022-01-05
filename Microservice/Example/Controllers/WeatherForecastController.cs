using Example.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class WeatherForecastController : ControllerBase
  {
    private readonly ServiceDbContext _dbContext = new ServiceDbContext();

    [HttpPost]
    public int Create(WeatherForecast item)
    {
      _dbContext.WeatherForecast.Add(item);
      _dbContext.SaveChanges();

      return item.Id;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> ReadAll()
    {
      return _dbContext.WeatherForecast;
    }

    [HttpGet("{id:int}")]
    public WeatherForecast? Read(int id)
    {
      return _dbContext
        .WeatherForecast
        .SingleOrDefault(x => x.Id == id);
    }
  }
}