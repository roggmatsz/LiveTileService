# LiveTileService

A simple, ASP.NET MVC web service complimentary to the [UWMPWeather](https://github.com/roggmatsz/Tutorial-UWPWeather)
app I made as I followed [this tutorial](https://channel9.msdn.com/Series/Windows-10-development-for-absolute-beginners/UWP-057-UWP-Weather--Introduction)
on Channel9.

## Description
LiveTileService is an ASP.NET MVC service. It returns the markup necessary, as per [this template catalog](https://msdn.microsoft.com/en-us/library/windows/apps/hh761491.aspx#TileSquareText01) to display text on an UWP app's 
Start Menu Tile.

The service expects an HTTP request of the format `http://livetileservicedomain/default/?lat=float&lon=float` where `lat` refers to latitude and `lon` refers to longitude. The values are received by `DefaultController.cs` and are trimmed before being passed 
onto an instance of `OpenWeatherMapProxy` class. This one, besides containing the object models for the JSON the OpenWeatherMaps.org API returns, also contains a static `GetWeather()` function used to retrieve data. 

That same class, incidentally, was also used in the [UWP app](https://github.com/roggmatsz/Tutorial-UWPWeather) this project was made for; it made me really understand just how cool and nifty it is to be able to reuse code at both client and server sides.

Upon retrieving the weather data, `ViewBag` variables are created to store the location name, temperature, and description. These then are referenced within the markup returned on the `index.cshtml` View.

## Next Steps

Just like with the [UWPWeather app](https://github.com/roggmatsz/Tutorial-UWPWeather) this service was built for, I plan to leave it as it is for now. Although I am *pretty* experienced with ASP.NET development in general, I still have a bit of ways to go on MVC knowledge, likely evidenced by the service's code. Thus, I plan to revisit this service as I extend and improve UWPWeather.
