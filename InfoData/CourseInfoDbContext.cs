using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using NickCollege.Models;

namespace NickCollege.InfoData
{
    public class CourseInfoDbContext : DbContext
    {
        public CourseInfoDbContext(DbContextOptions<CourseInfoDbContext> options)
    : base(options)
        {
        }
        public DbSet<NickCollege.Models.CourseInfo> CourseInfo { get; set; }
    }
}
