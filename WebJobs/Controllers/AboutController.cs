using Business.Abstract;
using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebJobs.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            AppDBContext dBContext = new AppDBContext();
            ViewBag.jobs = dBContext.Jobs.Count();
            ViewBag.category = dBContext.Categories.Count();
            var values = _aboutService.GetList();
            return View(values);
        }
    }
}
