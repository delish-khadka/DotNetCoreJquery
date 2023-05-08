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

        [HttpPost]
        public ActionResult StateData(int cid)
        {
            List<StateInfo> stateInfos = new List<StateInfo>()
            {
                new StateInfo(){SId=1,CId=101,SName="Bihar"},
                new StateInfo(){SId=2,CId=102,SName="Kathmandu"},
                new StateInfo(){SId=3,CId=101,SName="Delhi"},
                new StateInfo(){SId=4,CId=105,SName="Chin"},
                new StateInfo(){SId=5,CId=103,SName="Thimpu"},
                new StateInfo(){SId=6,CId=102,SName="Pokhara"},
                new StateInfo(){SId=7,CId=104,SName="Bangladesh"},
                new StateInfo(){SId=8,CId=105,SName="Chinland"},
                new StateInfo(){SId=9,CId=106,SName="Beach"},
                new StateInfo(){SId=10,CId=106,SName="Bali"},
                new StateInfo(){SId=11,CId=104,SName="Bengal"},
            };
            CitiesInfo model = new();
            model.stateInfosList = stateInfos.Where(s => s.CId == cid).ToList();
            return Json(model);
        }

        [HttpPost]
        public ActionResult CityData(int cid = 103)
        {
            List<CityInfo> cityInfos = new List<CityInfo>()
            {
                new CityInfo(){CityId=101,SId=1,CityName="Bihar"},
                new CityInfo(){CityId=102,SId=1,CityName="Kathmandu"},
                new CityInfo(){CityId=103,SId=1,CityName="Delhi"},
                new CityInfo(){CityId=104,SId=2,CityName="Chin"},
                new CityInfo(){CityId=105,SId=2,CityName="Thimpu"},
                new CityInfo(){CityId=106,SId=2,CityName="Pokhara"},
                new CityInfo(){CityId=107,SId=2,CityName="Bangladesh"},
                
            };
            CitiesInfo model = new();
            model.CityInfosList = cityInfos.Where(s => s.CityId == cid).ToList();
            return Json(model);
        }
    }
}
