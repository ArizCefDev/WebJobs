using Business.Abstract;
using DataAccess.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebJobs.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IMessageService _messageService;

        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult MessageNotification()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MessageAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MessageAdd(Message p)
        {
            _messageService.Insert(p);
            return RedirectToAction("MessageNotification","Contact");
        }
    }
}
