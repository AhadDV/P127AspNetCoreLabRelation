using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Dal
{
    public class LabDbContext:DbContext
    {
        public LabDbContext(DbContextOptions<LabDbContext> options):base(options)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Position> Positions { get; set; }
        
    }
}
