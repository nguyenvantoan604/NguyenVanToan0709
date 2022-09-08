using Microsoft.AspNetCore.Mvc;

namespace NguyenVanToan_0709.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
