using Microsoft.AspNetCore.Identity;
using System;


namespace NickCollege.Models
{
    public class UserViewModel : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Admin { get; set; }
        public string Teacher { get; set; }
        public string Student { get; set; }
    }
}
