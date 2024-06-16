using CLEANASPNETRestaurant.API.Datamodels;
using CLEANASPNETRestaurant.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CLEANASPNETRestaurant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
    {
        _logger = logger;
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet("")]
    public async Task<IActionResult> Get()
    {
        var result = await _weatherForecastService.Get();
        return Ok(result);
    }

    [HttpPost("generate/{maxresult}")]
    public async Task<IActionResult> Get(
        [FromRoute]int maxresult,
        [FromBody]GenerateWeatherRequest request)
    {
        if (maxresult <= 0 || request.MinTemperature >= request.MaxTemperature)
            return BadRequest("Invalid parameters");

        var result = await _weatherForecastService.Get(maxresult, request.MinTemperature, request.MaxTemperature);
        return Ok(result);
    }

    [HttpGet("today")]
    public async Task<IActionResult> GetToday()
    {
        var result = await _weatherForecastService.GetToday();
        return Ok(result);
    }
}
