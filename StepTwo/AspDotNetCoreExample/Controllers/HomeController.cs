using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspDotNetCoreExample.Models;
using AspDotNetCoreExample.BaseModel;
using Microsoft.Extensions.Options;

namespace AspDotNetCoreExample.Controllers
{
    public class HomeController : Controller
    {
        private EmailConfig _emailConfig = null;

        public HomeController(IOptions<EmailConfig> emailConfig)
        {
            _emailConfig = emailConfig.Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            ViewData["SMTP"] = _emailConfig.SMTP;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
