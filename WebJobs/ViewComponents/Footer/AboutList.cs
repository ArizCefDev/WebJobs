using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebJobs.ViewComponents.Footer
{
    public class AboutList : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public AboutList(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.GetList();
            return View(values);
        }
    }
}
