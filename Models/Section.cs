using System;
using System.ComponentModel.DataAnnotations;


namespace NickCollege.Models
{
    //[Authorize(Roles = "1123ASDGsdf123sdf")]
    public class Section
    {
        [Key] public int SectionID { get; set; }
        
        public string Location { get; set; }
        public string Classroom { get; set; }

        //[DataType(DateTime)]
        public string StartDate { get; set; }
        

    }
}
