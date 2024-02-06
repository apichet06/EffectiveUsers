using EffectiveUsers.Data;
using EffectiveUsers.Models;
using Microsoft.AspNetCore.Mvc;

namespace EffectiveUsers.Controllers
{
    public class AuthController : Controller
    {
 
        private readonly ApplicationDBContext _db;

        public AuthController(ApplicationDBContext db)
        {
            _db = db;
        } 

         [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
          
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Login(string userLogin, string Password)
        {
            var users = new Users();

            users.UserLogin = userLogin;
            users.Password = Password;

            if (string.IsNullOrEmpty(users.UserLogin) || string.IsNullOrEmpty(users.Password)) 
                return Json(new { success = false, message = "Invalid username or password" });
             
             if (ModelState.IsValid)
                 {
                    if (IsValidUser(users.UserLogin!, users.Password!))
                    {
                        HttpContext.Response.Cookies.Append("username", users.UserLogin!);
                       // return Json(new { success = true, message = "Successfuly" });
                    }
                    else
                    { 
                    return Json(new { success = false, message = "Invalid username or password" });
                }
             } 
            return Json(new { success = true, message = "Successfuly" });
        }
         
        private bool IsValidUser(string UserLogin, string password)
        {
            // ตรวจสอบข้อมูลเข้าสู่ระบบที่นี่ ตามที่คุณต้องการ
            // ตัวอย่างเช่น ตรวจสอบในฐานข้อมูลหรือตรวจสอบจากฐานข้อมูลของผู้ใช้งาน
            // เพื่อตรวจสอบว่าชื่อผู้ใช้และรหัสผ่านถูกต้องหรือไม่
            // ในที่นี้จะใช้เป็นตัวอย่างเท่านั้น
            return (UserLogin == "admin" && password == "password");
        }


    }
}
