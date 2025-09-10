using Microsoft.AspNetCore.Mvc;
using Municipality_Service_App.Models;
using static System.Net.WebRequestMethods;

namespace Municipality_Service_App.Controllers
{
    public class MainMenuController : Controller
    {
        private static IssueLinkedList issues = new IssueLinkedList();
        private readonly IWebHostEnvironment _env;

        public MainMenuController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpGet]
        public IActionResult ReportIssue()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ReportIssue(IssueViewModel model, IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                // Ensure upload folder exists in wwwroot
                var uploadPath = Path.Combine(_env.WebRootPath, "Uploads");
                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(uploadPath, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                model.FilePath = "/Uploads/" + fileName;
            }

            // Save issue into your custom linked list
            issues.AddIssue(model);

            // Redirect back to Home page
            return RedirectToAction("Index", "Home");
        }
    }
}

//<!-- Referencing -->
//<!--Microsoft Learn, 2025. LinkedList<T> Class [Online]. Available at:<https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1?view=net-9.0> [Acessed on 01 September 2025]-->
//<!--wheretostay,2020. Durban Beachfront Accommodation[Electronic Print]. Available at:<https://www.wheretostay.co.za/town/durban-beachfront-cbd/accommodation> [Acessed on 05 September 2025]-->
//<!--IStock,2019. Durban Beachfront [Electronic Print]. Available at:<https://www.istockphoto.com/search/2/image-film?phrase=durban+beach> [Acessed on 05 September 2025]-->
//<!--Facebook, 2012. EThekwini Municipality [Electronic Print]. Available at:<https://www.facebook.com/eThekwiniM/> [Acessed on 05 September 2025]--><!-- Referencing -->
