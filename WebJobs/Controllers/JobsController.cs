using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebJobs.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobsService _jobsService;

        public JobsController(IJobsService jobsService)
        {
            _jobsService = jobsService;
        }

        public IActionResult Index(string s)
        {
            var values = from a in _jobsService.GetList() select a;
            if (!string.IsNullOrEmpty(s))
            {
                values = _jobsService.GetJobSearch(s);
            }
            return View(values.OrderByDescending(x=>x.ID)); ;
        }
    }
}
