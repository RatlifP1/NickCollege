using System;
using System.ComponentModel.DataAnnotations;

namespace NickCollege.Models
{
 

    public class CourseInfo 
    {
        
        
    [Key] public int CourseID { get; set; }
      
    public string CourseName { get; set; }
        public string CourseDescribtion { get; set; }

        public int Credits { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public double grade1 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public double grade2 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public double grade3 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public double grade4 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public double grade5 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public double grade6 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public double grade7 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public double grade8 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public double grade9 { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public double grade10 { get; set; }


        public double average { get; set; }
        
    }
}
