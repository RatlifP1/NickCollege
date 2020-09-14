using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using NickCollege.Models;

namespace NickCollege.InfoData
{
    public class SectionDbContext : DbContext

    {
        public SectionDbContext(DbContextOptions<SectionDbContext> options)
    : base(options)
        {
        }
        public DbSet<NickCollege.Models.Section> Section { get; set; }
    }
}
