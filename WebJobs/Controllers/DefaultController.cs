using Business.Abstract;
using Business.Concrete;
using DataAccess.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebJobs.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IJobsService _jobsService;

        public DefaultController(IJobsService jobsService)
        {
            _jobsService = jobsService;
        }

        public IActionResult Index()
        {
            var values = _jobsService.GetList();
            return View(values.OrderByDescending(x=>x.ID));
        }

        public IActionResult JobDetails(int id)
        {
            var values = _jobsService.GetJobID(id);
            return View(values);
        }
    }
}
