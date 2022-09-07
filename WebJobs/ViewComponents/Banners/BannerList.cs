using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebJobs.ViewComponents.Banners
{
    public class BannerList : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
