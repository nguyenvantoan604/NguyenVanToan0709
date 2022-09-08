using Microsoft.AspNetCore.Mvc;

namespace NguyenVanToan_0709.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
