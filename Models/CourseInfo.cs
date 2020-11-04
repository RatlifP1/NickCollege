using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NickCollege.Controllers;
using Microsoft.Extensions.WebEncoders;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace NickCollege.Models
{

    public class CourseInfo 
    {
        [Key] public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescribtion { get; set; }

        public int Credits { get; set; }

        public double grade1 { get; set; }
        public double grade2 { get; set; }
        public double grade3 { get; set; }
        public double grade4 { get; set; }
        public double grade5 { get; set; }
        public double grade6 { get; set; }
        public double grade7 { get; set; }
        public double grade8 { get; set; }
        public double grade9 { get; set; }
        public double grade10 { get; set; }
        public double average { get; set; }

        public int? FK_UserID { get; set; }

    }
}
