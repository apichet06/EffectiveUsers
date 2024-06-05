using EffectiveUsers.Data;
using EffectiveUsers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EffectiveUsers.Controllers
{
    

    public class UsersController : Controller
    {
        private readonly ApplicationDBContext _db;
        public  UsersController(ApplicationDBContext db)
        {
            _db = db;
        }
         
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

        [HttpGet]
        public IActionResult Create()
        {
            List<Status> allstatus = _db.status.ToList();
            List<Division> allDivisions = _db.Divisions.ToList();
            //List<Position> allPositions = _db.Positions.ToList();

            ViewData["Divisions"] = allDivisions;
            //ViewData["Positions"] = allPositions;

            return View(allstatus);
        }

        [HttpGet] //รายการ Position ตำแหน่ง หลังจากการเลือก Position 
        public IActionResult GetPositionsByDivision(string divisionId)
        {
            List<Position> positions = _db.Positions.Where(p => p.DV_ID == divisionId).ToList();
            return Json(positions);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromForm] Users users)
        {
            try
            {
                _db.Add(users);
                await _db.SaveChangesAsync(); 
                return Json(new { success = false, message = "บันทึกข้อมูลสำเร็จ!" });

            } catch (Exception ex)
            {
                ModelState.AddModelError("", "เกิดข้อผิดพลาดในการบันทึกมข้อมูล");
                return Json(new { success = false, message = ex.Message});
            }
             
        }
         
        public JsonResult GetChartData()
        {
            // สร้างข้อมูลกราฟ (สามารถดึงจากฐานข้อมูลหรือแหล่งข้อมูลอื่น ๆ ก็ได้)
            var data = new
            {
                labels = new[] { "Red", "Blue", "Yellow", "Green", "Purple", "Orange" },
               
                datasets = new[] 
                {
                    new { 
                        label = "# of Votes",
                        data = new[] { 12, 19, 3, 5, 2, 3 },
                        backgroundColor = new[] { "red", "blue", "yellow", "green", "purple", "orange" },
                        borderWidth = 1 
                    } 
            }

            };

            return Json(data);
        }
    }
}
