using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistanceLayerNoGeneric.Repositories;
using Entities.School;
using MyDatabase;
using PersistanceGeneric.Repositories;
using ProjectRepository = PersistanceGeneric.Repositories.ProjectRepository;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            GenericRepository<Student> studentService = new GenericRepository<Student>(context);
            GenericRepository<Project> projectService = new GenericRepository<Project>(context);

            ProjectRepository projectRepository = new ProjectRepository(context);

            var projects = projectRepository.GetProjectsOrderByAsc();

            foreach (var item in projects)
            {
                Console.WriteLine(item);
            }


            var students = studentService.GetAll();
            foreach (var stu in students)
            {
                Console.WriteLine(stu.Name);
            }

            

        }
    }
}
