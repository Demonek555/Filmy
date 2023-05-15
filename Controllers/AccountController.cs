using Filmy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmy.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private SignInManager<AppUser> SignInMgr { get; }

        public AccountController(UserManager<AppUser> userMgr, SignInManager<AppUser> signInMgr)
        {
            UserMgr = userMgr;
            SignInMgr = signInMgr;
        }

        public async Task<IActionResult> Register()
        {
            try
            {
                ViewBag.message = "User stworzony";
                AppUser user = await UserMgr.FindByNameAsync("TestUser");
            }
            catch(Exception ex)
            {

            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
