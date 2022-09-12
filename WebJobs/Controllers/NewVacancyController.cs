using Business.Abstract;
using Business.ValidationRules;
using DataAccess.Entity;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace WebJobs.Controllers
{
    [AllowAnonymous]
    public class NewVacancyController : Controller
    {
        private readonly IJobsService _jobsService;
        private readonly ICategoryService _categoryService;

        public NewVacancyController(IJobsService jobsService, ICategoryService categoryService)
        {
            _jobsService = jobsService;
            _categoryService = categoryService;
        }

        public IActionResult VacancyMessage()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewVacancyAdd()
        {
            IEnumerable<SelectListItem> valueGet = (from x in _categoryService.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.ID.ToString()
                                                    }).ToList();
            ViewBag.c = valueGet;
            return View();
        }

        [HttpPost]
        public IActionResult NewVacancyAdd(Job p)
        {
            IEnumerable<SelectListItem> valueGet = (from x in _categoryService.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value = x.ID.ToString()
                                                    }).ToList();
            ViewBag.c = valueGet;

            JobsValidator jbv = new JobsValidator();
            ValidationResult results = jbv.Validate(p);
            if (results.IsValid)
            {
                p.Status = true;
                _jobsService.Insert(p);
                return RedirectToAction("VacancyMessage", "NewVacancy");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(p);
        }
    }
}
