using Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceGeneric.IRepositories
{
    public interface ICourseRepository: IGenericRepository<Course>
    {
        IEnumerable<Course> GetCoursesOrderByAsc();
    }
}
