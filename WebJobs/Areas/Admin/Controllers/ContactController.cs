using Business.Abstract;
using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebJobs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
        {
            var values = _contactService.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult ContactUpdate(int id)
        {
            var values = _contactService.GetID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult ContactUpdate(Contact p)
        {
            p.Status = true;
            _contactService.Update(p);
            return RedirectToAction("Index", "Contact");
        }
    }
}
