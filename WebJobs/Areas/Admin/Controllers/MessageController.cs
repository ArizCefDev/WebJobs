using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Index()
        {
            var values = _messageService.GetList();
            return View(values);
        }
    }
}
