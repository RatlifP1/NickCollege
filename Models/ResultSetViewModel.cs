using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using NickCollege.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace NickCollege.Models
{
    public class ResultSetViewModel : IdentityUser

    {
        //public CourseInfo CourseVM { get; set; }
        //public Section SectionVM { get; set; }

        //public ApplicationUser UserManager { get; set; }
        //public UserManager<ApplicationUser> UserManager { get; internal set; }

        //private readonly List<ApplicationUser> UserManager;
        //[PersonalData]
        //[Column(TypeName = "nvarchar(100)")]
        //public UserManager<ApplicationUser> userManager { get; private set; }
        public string FirstName { get; set; }
        //[PersonalData]
        //[Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        //[PersonalData]
        //[Column(TypeName = "nvarchar(100)")]
        public string Admin { get; set; }
        //[PersonalData]
        //[Column(TypeName = "nvarchar(100)")]
        public string Teacher { get; set; }
        //[PersonalData]
        //[Column(TypeName = "nvarchar(100)")]
        public string Student { get; set; }




        //struct User
        //{
        //    public Guid Id { get; }
        //    public Guid UserName { get; }
        //}



        //private readonly List<ApplicationUser> user = new List<ApplicationUser>();

        //private readonly List<ApplicationUser> UserManager;
        //private readonly List<User> user = new List<User>();
        //[Display(Name = "Students")]
   

        //Filter to include only customers whose country is "United States"
        //var finduser = from ApplicationUser in user
        //               where UserLoginInfo  == "United States"
        //               select UserManager;


        //public IEnumerable<SelectListItem> UserItems
        //{
        //    get { return new SelectList(UserManager, "Id", "UserName"); }
        //}
    }
}
