using EffectiveUsers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace EffectiveUsers.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        { 
            return View();
        }
        [HttpGet]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Chart() { 
          return View();
        }

    }
}
