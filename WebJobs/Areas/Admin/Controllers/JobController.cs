using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebJobs.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobController : Controller
    {
        private readonly IJobsService _jobsService;

        public JobController(IJobsService jobsService)
        {
            _jobsService = jobsService;
        }

        public IActionResult Index()
        {
            var values = _jobsService.GetList();
            return View(values);
        }
    }
}
