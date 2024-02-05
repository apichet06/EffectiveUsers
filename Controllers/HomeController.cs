using EffectiveUsers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EffectiveUsers.Controllers
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
            var s1 = new Users();
            s1.Id = 1;
            s1.Username = "test";
            s1.Password = "123456";

           var s2 = new Users();
            s2.Id = 2;
            s2.Username = "test";
            s2.Password = "123456";

           var allUser = new List<Users>();
                allUser.Add(s1);
                allUser.Add(s2);
            return View(allUser);
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
