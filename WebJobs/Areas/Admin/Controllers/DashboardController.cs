using Microsoft.AspNetCore.Mvc;

namespace WebJobs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
