using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NickCollege.Models;

namespace NickCollege.Controllers
{
    public class CourseAndSectionViewController : Controller
    //public class CourseAndSectionView 
    {
        List<CourseInfo> courseInfo = new List<CourseInfo>();
        List<Section> section = new List<Section>();

        public IActionResult CnSView()
        {

            var studentViewModel = from s in courseInfo
                                   join st in section on s.CourseID equals st.SectionID into st2
                                   from st in st2.DefaultIfEmpty()
                                   select new StudentViewModel { CourseInfoVm = s, SectionVm = st };
            return View(studentViewModel);
        }
    }
}