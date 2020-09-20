using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using verificationproject.Models;

namespace verificationproject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

private TokenGenerator tokengenerate = new TokenGenerator();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
/*var tokenString = tokengenerate.GenerateJSONWebToken();
            List<Model Class name> weatherForecastList = new List<Model Class Name>();
            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenString);
                using (var response = await httpClient.GetAsync("API link to be entered here"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    weatherForecastList = JsonConvert.DeserializeObject<List<WeatherForecast>>(apiResponse);
                }
            }
            return View("Enter the name of the view page", weatherForecastList);*/
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
