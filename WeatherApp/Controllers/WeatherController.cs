using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        // Hardcoded list of cities weather
        List<CityWeather>? citiesWeather = new List<CityWeather>()
        {
            new CityWeather { CityUniqueCode = "LDN",
            CityName = "London",
            DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),
            TemperatureFahrenheit = 33},
            new CityWeather { CityUniqueCode = "NYC",
            CityName = "London",
            DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),
            TemperatureFahrenheit = 60},
            new CityWeather { CityUniqueCode = "PAR",
            CityName = "Paris",
            DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),
            TemperatureFahrenheit = 82}
        };
        [Route("/")]
        public IActionResult Index()
        {
            return View(citiesWeather);
        }
        [Route("/Weather/{cityCode}")]
        public IActionResult CityDetails(string cityCode)
        {
            CityWeather? cityWeather = citiesWeather?.Where(city => city.CityUniqueCode == cityCode).FirstOrDefault();
            if (cityWeather == null)
            {
                return Content("City not found");
            }
            return View(cityWeather);
        }   
    }
}
