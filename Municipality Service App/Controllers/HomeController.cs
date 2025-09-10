using Microsoft.AspNetCore.Mvc;
using Municipality_Service_App.Models;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace Municipality_Service_App.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
//<!-- Referencing -->
//<!--Microsoft Learn, 2025. LinkedList<T> Class [Online]. Available at:<https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-9.0> [Acessed on 01 September 2025]-->
//<!--wheretostay,2020. Durban Beachfront Accommodation[Electronic Print]. Available at:<https://www.wheretostay.co.za/town/durban-beachfront-cbd/accommodation> [Acessed on 05 September 2025]-->
//<!--IStock,2019. Durban Beachfront [Electronic Print]. Available at:<https://www.istockphoto.com/search/2/image-film?phrase=durban+beach> [Acessed on 05 September 2025]-->
//<!--Facebook, 2012. EThekwini Municipality [Electronic Print]. Available at:<https://www.facebook.com/eThekwiniM/> [Acessed on 05 September 2025]--><!-- Referencing -->
