using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistanceLayerNoGeneric.Repositories;
using Entities.School;
using MyDatabase;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            StudentRepository studentService = new StudentRepository(db);
            ProjectRepository projectService = new ProjectRepository(db);

            foreach (var pro in projectService.GetAll())
            {
                Console.WriteLine(pro.Title + " " + pro.Student.Name);
            }

        }
    }
}
