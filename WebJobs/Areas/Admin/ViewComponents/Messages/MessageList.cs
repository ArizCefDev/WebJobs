using Business.Abstract;
using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebJobs.Areas.Admin.ViewComponents.Messages
{
    public class MessageList : ViewComponent
    {
        private readonly IMessageService _messageService;

        public MessageList(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            AppDBContext dBContext = new AppDBContext();

            var values = _messageService.GetList();
            ViewBag.message = dBContext.Messages.Count();
            return View(values);
        }
    }
}
