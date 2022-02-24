using Entities.School;
using MyDatabase;
using PersistanceGeneric.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceGeneric.Repositories
{
    public class CourseRepository:GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(ApplicationDbContext context): base(context)
        {

        }
        public IEnumerable<Course> GetCoursesOrderByAsc()
        {
            return Context.Courses.OrderBy(x=>x.Title).ToList();
        }
    }
}
