using CLEANASPNETRestaurant.API.Datamodels;

namespace CLEANASPNETRestaurant.API.Interfaces
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> Get();

        Task<IEnumerable<WeatherForecast>> Get(int maxresult, int mintemp, int maxtemp);

        Task<WeatherForecast> GetToday();
    }
}