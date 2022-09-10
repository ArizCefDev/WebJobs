using Microsoft.AspNetCore.Mvc;

namespace WebJobs.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
