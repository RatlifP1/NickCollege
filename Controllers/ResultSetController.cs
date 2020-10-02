using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NickCollege.Models;

namespace NickCollege.Controllers
{
    public class ResultSetController : Controller
    {
        
        //public ActionResult GetBlogComment()
        //{
        //    ResultSetViewModel CSVM = new ResultSetViewModel();
        //    CSVM.CourseVM = GetCourseVM();
        //    CSVM.SectionVM = GetSectionVM();
        //    return View(CSVM);
        //}





        public ActionResult GetCourseVMSectionVM()
        {
            ViewBag.CourseInfoVM = GetCourseVMSectionVM();
            ViewBag.SectionVM = GetCourseVMSectionVM();
            return View();
        }
    }
}
