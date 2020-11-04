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
using Microsoft.EntityFrameworkCore;

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
        public Grade? grade1 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? grade2 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? grade3 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? grade4 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? grade5 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? grade6 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? grade7 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? grade8 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? grade9 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? grade10 { get; set; }


        public double average { get; set; }

    }
}
