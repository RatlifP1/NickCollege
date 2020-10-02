using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using NickCollege.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NickCollege.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
       

    [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Admin { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Teacher { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Student { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(10)")]


        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public Section SectionID { get; set; }






    }
}
