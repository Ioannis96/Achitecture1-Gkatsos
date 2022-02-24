using Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Seeding
{
    public class SeedingService
    {
        ApplicationDbContext db;

        public SeedingService(ApplicationDbContext context)
        {
            db = context;
        }

        public void SeedStudents()
        {
            Boomer b1 = new Boomer() { Name = "Costas" };
            Boomer b2 = new Boomer() { Name = "Ioannis" };
            Boomer b3 = new Boomer() { Name = "Giannis" };
            Boomer b4 = new Boomer() { Name = "Niki" };
            Boomer b5 = new Boomer() { Name = "Dimitris" };

            Student s1 = new Student() { Name = "Hector",Age =34 };
            Student s2 = new Student() { Name = "Mpampis", Age = 29 };
            Student s3 = new Student() { Name = "Lakis", Age = 26 };
            Student s4 = new Student() { Name = "Fanis", Age = 23 };

            Project p1 = new Project() { Title = "C#" };
            Project p2 = new Project() { Title = "Java" };
            Project p3 = new Project() { Title = "Python" };
            Project p4 = new Project() { Title = "HTML" };

            Course c1 = new Course() { Title = "Course in C#" };
            Course c2 = new Course() { Title = "Course in Java" };
            Course c3 = new Course() { Title = "Course in Python" };
            Course c4 = new Course() { Title = "Course in HTML" };
            Course c5 = new Course() { Title = "Course in C++" };

            db.Courses.Add(c1);
            db.Courses.Add(c2);
            db.Courses.Add(c3);
            db.Courses.Add(c4);
            db.Courses.Add(c5);

            p1.Student = s1;
            p2.Student = s2;
            p3.Student = s3;
            p4.Student = s4;

            db.Projects.Add(p1);
            db.Projects.Add(p2);
            db.Projects.Add(p3);
            db.Projects.Add(p4);

            db.Boomers.Add(b1);
            db.Boomers.Add(b2);
            db.Boomers.Add(b3);
            db.Boomers.Add(b4);
            db.Boomers.Add(b5);

            db.Students.Add(s1);
            db.Students.Add(s2);
            db.Students.Add(s3);
            db.Students.Add(s4);

            db.SaveChanges();
        }

        public void SeedJanitors()
        {
            Janitor j1 = new Janitor() { Name = "Lampis" };
            Janitor j2 = new Janitor() { Name = "Fampis" };
            Janitor j3 = new Janitor() { Name = "Tampis" };
            Janitor j4 = new Janitor() { Name = "Bampis" };

            db.Janitors.Add(j1);
            db.Janitors.Add(j2);
            db.Janitors.Add(j3);
            db.Janitors.Add(j4);
        }


    }
}
