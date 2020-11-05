using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NickCollege.Areas.Identity.Data;

namespace NickCollege.Controllers
{
    public class AdministrationController : Controller
    {

        private readonly UserManager<ApplicationUser> userManager;

        public AdministrationController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = userManager.Users;
            return View(users);
        }
    }
    }