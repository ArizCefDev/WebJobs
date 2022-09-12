using DataAccess.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebJobs.Models;

namespace WebJobs.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //[HttpGet]
        //public IActionResult SignUp()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> SignUp(UserRegisterViewModel p)
        //{
        //    AppUser appUser = new AppUser()
        //    {
        //        UserName = p.UserName,
        //    };

        //    if (p.Password == p.ConfirmPassword)
        //    {
        //        var result = await _userManager.CreateAsync(appUser, p.Password);
        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("SignIn");
        //        }
        //        else
        //        {
        //            foreach (var item in result.Errors)
        //            {
        //                ModelState.AddModelError("", item.Description);
        //            }
        //        }
        //    }
        //    return View(p);
        //}

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                }
                else
                {
                    return RedirectToAction("SignIn");
                }
            }
            return View();
        }
    }
}
