using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebJobs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
        {
            var values = _messageService.GetList();
            return View(values.OrderByDescending(x => x.ID));
        }

        public IActionResult MessageDetails(int id)
        {
            var values = _messageService.GetID(id);
            return View(values);
        }

        public IActionResult MessageDelete(int id)
        {
            var values = _messageService.GetID(id);
            _messageService.Delete(values);
            return RedirectToAction("Index","Message");
        }
    }
}
