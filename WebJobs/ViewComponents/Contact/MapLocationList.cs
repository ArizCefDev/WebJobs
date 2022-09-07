using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebJobs.ViewComponents.Contact
{
    public class MapLocationList : ViewComponent
    {
        private readonly IContactService _contactService;

        public MapLocationList(IContactService contactService)
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
