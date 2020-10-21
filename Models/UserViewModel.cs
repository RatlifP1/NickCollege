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
    public class UserViewModel : IdentityUser
    {
       
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
    }
}
