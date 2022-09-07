using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebJobs.ViewComponents.Categories
{
    public class CategoryList : ViewComponent
    {
        AppDBContext dbc = new AppDBContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.backend = dbc.Jobs.Where(x => x.CategoryID == 1).Count();
            ViewBag.frontend = dbc.Jobs.Where(x => x.CategoryID == 2).Count();
            ViewBag.fullstack = dbc.Jobs.Where(x => x.CategoryID == 3).Count();
            return View();
        }
    }
}
