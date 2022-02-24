using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.School;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using Entities.IdentityUsers;
using MyDatabase.Initializers;

namespace MyDatabase
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("Sindesmos")
        {
            Database.SetInitializer<ApplicationDbContext>(new MockupDbInitializer());
            Database.Initialize(false);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Janitor> Janitors { get; set;}

        public DbSet<Trainer> Trainers { get; set; }


        public DbSet<Course> Courses { get; set;}

        public DbSet<Boomer> Boomers { get; set;}


    }
}
