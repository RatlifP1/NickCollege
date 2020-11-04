using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NickCollege.Models;
using NickCollege.InfoData;
using NickCollege.Data;
using Microsoft.AspNetCore.Identity;
using NickCollege.Areas.Identity.Data;

namespace NickCollege.Controllers
{
    public class ResultSetController : Controller
    {
        CourseInfoDbContext cidb;
        SectionDbContext sdb;
        //AuthDbContext adbc;

        public ResultSetController(CourseInfoDbContext cidb, SectionDbContext sdb/*   , AuthDbContext adbc*/)
        {
            this.cidb = cidb;
            this.sdb = sdb;
            //this.adbc = adbc;
        }
    
        /***********************************************************************************************************/
        //private readonly UserManager<ApplicationUser> userManager;

        //public ResultSetController(UserManager<ApplicationUser> userManager)
        //{
        //    this.userManager = userManager;
        //}
        /***************************************************************************************************************/

        [HttpGet]
        public ActionResult GetCourseVMSectionVM()
        {
            //var users = userManager.Users;

            var CourseInfoVM = cidb.CourseInfo.First();
           var SectionVM = sdb.Section.First();
            
            var model = new ResultSetViewModel { CourseVM = CourseInfoVM, SectionVM = SectionVM };
            
            return View(model);
        }


        //private readonly UserManager<ApplicationUser> userManager;

        //public ResultSetController(UserManager<ApplicationUser> userManager)
        //{
        //    this.userManager = userManager;
        //}

        //[HttpGet]
        //public IActionResult ListUsers()
        //{
        //    var users = userManager.Users;
        //    return View(users, model);
        //}

        //public ActionResult GetView(string customerID, string viewName)
        //{
        //    object model = null;
        //    if (viewName == "CustomerDetails")
        //    {
        //        using AuthDbContext db = new AuthDbContext();
        //        model = db.userManager.Find(customerID);
        //    }
        //    if (viewName == "OrderDetails")
        //    {
        //        using (NorthwindEntities db = new NorthwindEntities())
        //        {
        //            model = db.Orders.Where(o => o.CustomerID == customerID)
        //                      .OrderBy(o => o.OrderID).ToList();
        //        }
        //    }
        //    return PartialView(users, model);
        //}
    }
}
