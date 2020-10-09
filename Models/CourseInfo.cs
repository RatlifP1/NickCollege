using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NickCollege.Controllers;
using Microsoft.Extensions.WebEncoders;
using System.Data;
using NickCollege.Areas.Identity.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Routing;
using System.ComponentModel.DataAnnotations.Schema;

namespace NickCollege.Models
{
    public enum Grade
    {
        A , B, C, D, F
    }

    public class CourseInfo /*: GradeAndAvgController*/
    {
        
        
    [Key] public int CourseID { get; set; }
      
    public string CourseName { get; set; }
        public string CourseDescribtion { get; set; }

        public int Credits { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public double average { get; set; }


      

    }
}
