using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using School.Web.Data.Entities;

namespace School.Web.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Material>  Materials { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Result> Results { get; set; }



    }
}
