using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NickCollege.Models;
using NickCollege.InfoData;
using NickCollege.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using NickCollege.Areas.Identity.Data;

namespace NickCollege.Controllers
{

    public class ResultSetController : Controller
    {


        private AuthDbContext _userManager;
        public ResultSetController(AuthDbContext userManager)
        {
            _userManager = userManager;
        }
        public IActionResult UserView()
        {
            ViewData["Message"] = "Your application describtion page.";
            return View(_userManager.Users.ToList());
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        ////CourseInfoDbContext cidb;
        ////SectionDbContext sdb;
        //AuthDbContext authdc;

        //public ResultSetController(/*CourseInfoDbContext cidb, SectionDbContext sdb, */AuthDbContext authdc)
        //{
        //    //this.cidb = cidb;
        //    //this.sdb = sdb;
        //    this.authdc = authdc;
        //}




        //private readonly UserManager<ApplicationUser> userManager;

        //public ResultSetController(UserManager<ApplicationUser> userManager)
        //{
        //    this.userManager = userManager;
        //}








        //public ActionResult GetCourseVMSectionVM()
        //{

        //    //var users = userManager.Users;
        //    //var CourseInfoVM = cidb.CourseInfo.First();
        //    //    var SectionVM = sdb.Section.First();
        //    //var ApplicationUser = authdc._userManager;

        //    //var model = new ResultSetViewModel { /*CourseVM = CourseInfoVM, SectionVM = SectionVM,*/ _userManager = (UserManager<ApplicationUser>)ApplicationUser };

        //    return View();
        //    //return View(model);
        //}
    }
}
