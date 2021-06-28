using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HREntity.Models;

namespace HREntity.Data
{
    public class HREntityContext : DbContext
    {
        public HREntityContext (DbContextOptions<HREntityContext> options)
            : base(options)
        {
        }

        public DbSet<HREntity.Models.Employee> Employee { get; set; }

        public DbSet<HREntity.Models.Employer> Employer { get; set; }

        public DbSet<HREntity.Models.Testimonial> Testimonial { get; set; }

        public DbSet<HREntity.Models.Achievments> Achievments { get; set; }

        public DbSet<HREntity.Models.Feedback> Feedback { get; set; }
    }
}
