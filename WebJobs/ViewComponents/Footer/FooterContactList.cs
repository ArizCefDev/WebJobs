using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebJobs.ViewComponents.Footer
{
    public class FooterContactList : ViewComponent
    {
        private readonly IContactService _contactService;

        public FooterContactList(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactService.GetList();
            return View(values);
        }
    }
}
