using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NickCollege.Models;
using NickCollege.InfoData;

namespace NickCollege.Controllers
{
    public class ResultSetController : Controller
    {
        CourseInfoDbContext cidb;
        SectionDbContext sdb;

        public ResultSetController(CourseInfoDbContext cidb, SectionDbContext sdb)
        {
            this.cidb = cidb;
            this.sdb = sdb;
        }

        public ActionResult GetCourseVMSectionVM()
        {
           var CourseInfoVM = cidb.CourseInfo.First();
           var SectionVM = sdb.Section.First();

            var model = new ResultSetViewModel { CourseVM = CourseInfoVM, SectionVM = SectionVM };

            return View(model);
        }


    }
}
