using Business.Abstract;
using DataAccess.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace WebJobs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobController : Controller
    {
        private readonly IJobsService _jobsService;
        private readonly ICategoryService _categoryService;

        public JobController(IJobsService jobsService, ICategoryService categoryService)
        {
            _jobsService = jobsService;
            _categoryService = categoryService;
        }

        [Route("Admin/[controller]/[action]")]
        public IActionResult Index()
        {
            var values = _jobsService.GetJobWithCategory();
            return View(values.OrderByDescending(x=>x.ID));
        }

        [HttpGet]
        public IActionResult JobUpdate(int id)
        {
            var values = _jobsService.GetID(id);

            IEnumerable<SelectListItem> valueGet = (from x in _categoryService.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.ID.ToString()
                                                    }).ToList();
            ViewBag.c = valueGet;

            return View(values);
        }

        [HttpPost]
        public IActionResult JobUpdate(Job p)
        {
            IEnumerable<SelectListItem> valueGet = (from x in _categoryService.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.ID.ToString()
                                                    }).ToList();
            ViewBag.c = valueGet;
            p.Status = true;
            _jobsService.Update(p);
            return RedirectToAction("Index","Job");
        }

        public IActionResult JobDelete(int id)
        {
            var values = _jobsService.GetID(id);
            _jobsService.Delete(values);
            return RedirectToAction("Index", "Job");
        }

        public IActionResult ChangeToTrue(int id)
        {
            _jobsService.ChangeStatusTrue(id);
            return RedirectToAction("Index", "Job");
        }

        public IActionResult ChangeToFalse(int id)
        {
            _jobsService.ChangeStatusFalse(id);
            return RedirectToAction("Index", "Job");
        }
    }
}
