using DotNetCoreJquery.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreJquery.Controllers
{
    public class LocationController : Controller
    {
        public IActionResult Index()
        {
            CitiesInfo citiesInfo = new CitiesInfo();
            //citiesInfo.CountryInfosList.Add(new CountryInfo { CId = 0, CName = "Select Country" });

            citiesInfo.CountryInfosList.Add(new CountryInfo { CId = 101, CName = "India" });
            citiesInfo.CountryInfosList.Add(new CountryInfo { CId = 102, CName = "Nepal" });
            citiesInfo.CountryInfosList.Add(new CountryInfo { CId = 103, CName = "Bhutan" });
            citiesInfo.CountryInfosList.Add(new CountryInfo { CId = 104, CName = "Bangladesh" });
            citiesInfo.CountryInfosList.Add(new CountryInfo { CId = 105, CName = "China" });
            citiesInfo.CountryInfosList.Add(new CountryInfo { CId = 106, CName = "Srilanka" });

            return View(citiesInfo);
        }
    }
}
