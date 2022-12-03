using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectMVC.Models;

namespace ProjectMVC.Data
{
    public class ProjectMVCContext : DbContext
    {
        public ProjectMVCContext (DbContextOptions<ProjectMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
    }
}
