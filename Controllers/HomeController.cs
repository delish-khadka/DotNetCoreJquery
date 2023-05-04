using DotNetCoreJquery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetCoreJquery.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        [HttpPost]
        public CalculateModel CalculateNumber(int num1, int num2, string text)
        {
            CalculateModel calculateModel = new();
            calculateModel.Add = num1 + num2;
            calculateModel.Sub = num1 - num2;
            calculateModel.Mul = num1 * num2;
            calculateModel.Divide =(decimal) num1/ num2;
              
            return calculateModel;
        }
        [HttpPost]
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        [HttpPost]
        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}