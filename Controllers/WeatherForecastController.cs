using Microsoft.AspNetCore.Mvc;

namespace Restaurants.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWheaterForecastService _weatherForecastService;

    public WeatherForecastController(
        ILogger<WeatherForecastController> logger,
        IWheaterForecastService weatherForecastService
    )
    {
        _logger = logger;
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        var result = _weatherForecastService.Get();
        return result;
    }

    [HttpGet]
    [Route("Second")]
    public IEnumerable<WeatherForecast> Get2()
    {
        var result = _weatherForecastService.Get();
        return result;
    }
}
