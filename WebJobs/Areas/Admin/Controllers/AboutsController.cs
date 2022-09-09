using Business.Abstract;
using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebJobs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutsController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
        {
            var values = _aboutService.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AboutUpdate(int id)
        {
            var values = _aboutService.GetID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult AboutUpdate(About p)
        {
            p.Status = true;
            p.Image = "/WebJobs/images/ab.png";
            _aboutService.Update(p);
            return RedirectToAction("Index","Abouts");
        }
    }
}
