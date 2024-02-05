using EffectiveUsers.Models;
using Microsoft.AspNetCore.Mvc;

namespace EffectiveUsers.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }
         [HttpGet]
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Login(Users users) {

            if(ModelState.IsValid)
            {
                if (IsValidUser(users.UserLogin!, users.Password!)) {
                    HttpContext.Response.Cookies.Append("username", users.Username!);
                    return RedirectToAction("Index","Student");

                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password");
                }
            }


            return View(users); 
        }

        private bool IsValidUser(string username, string password)
        {
            // ตรวจสอบข้อมูลเข้าสู่ระบบที่นี่ ตามที่คุณต้องการ
            // ตัวอย่างเช่น ตรวจสอบในฐานข้อมูลหรือตรวจสอบจากฐานข้อมูลของผู้ใช้งาน
            // เพื่อตรวจสอบว่าชื่อผู้ใช้และรหัสผ่านถูกต้องหรือไม่
            // ในที่นี้จะใช้เป็นตัวอย่างเท่านั้น
            return (username == "admin" && password == "password");
        }


    }
}
