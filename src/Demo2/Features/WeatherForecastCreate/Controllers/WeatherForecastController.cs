using Example.Features.WeatherForecastCreate.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace Example.Features.WeatherForecastCreate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WeatherForecastCreateDbContext _dbContext;

        public WeatherForecastController(WeatherForecastCreateDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public int Create(WeatherForecastForCreate item)
        {
            _dbContext.WeatherForecast.Add(item);
            _dbContext.SaveChanges();

            return item.Id;
        }
    }
}