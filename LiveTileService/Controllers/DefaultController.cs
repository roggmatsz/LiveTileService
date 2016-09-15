using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LiveTileService.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public async Task<ActionResult> Index(string lat, string lon)
        {
            //Let us validate
            double latidude = double.Parse(lat.Substring(0, 5));
            double longitude = double.Parse(lon.Substring(0, 5));

            var weather = await Models.OpenWeatherMapProxy.GetWeather(latidude, longitude);

            ViewBag.Name = weather.name;
            ViewBag.Description = weather.weather[0].description;
            ViewBag.Temp = ((int)weather.main.temp).ToString();
            return View();
        }
    }
}