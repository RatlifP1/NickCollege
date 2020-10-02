using Microsoft.AspNetCore.Authorization;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using NickCollege.Controllers;
using Microsoft.Extensions.WebEncoders;
using System.Data;
using System.Data.SqlClient;

using System.Dynamic;
using NickCollege.Areas.Identity.Data;
using NickCollege.Areas.Identity.Pages.Account;
using System.ComponentModel.DataAnnotations.Schema;

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
