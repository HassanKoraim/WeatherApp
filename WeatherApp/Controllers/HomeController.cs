using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
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
            return View(citiesWeather);
        }
        [Route("/Weather/{cityCode}")]
        public IActionResult CityDetails(string cityCode)
        {
            CityWeather? cityWeather = new CityWeather();
            if (cityCode == "LDN")
            {
                cityWeather.CityUniqueCode = "LDN";
                cityWeather.CityName = "London";
                cityWeather.DateAndTime = Convert.ToDateTime("2030-01-01 8:00");
                cityWeather.TemperatureFahrenheit = 33;
            }
            else if (cityCode == "NYC")
            {
                cityWeather.CityUniqueCode = "NYC";
                cityWeather.CityName = "New York";
                cityWeather.DateAndTime = Convert.ToDateTime("2030-01-01 3:00");
                cityWeather.TemperatureFahrenheit = 60;
            }
            else if (cityCode == "PAR")
            {
                cityWeather.CityUniqueCode = "PAR";
                cityWeather.CityName = "Paris";
                cityWeather.DateAndTime = Convert.ToDateTime("2030-01-01 9:00");
                cityWeather.TemperatureFahrenheit = 82;
            }
            return View(cityWeather);
        }   
    }
}
