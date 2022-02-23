using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.School;
using MyDatabase;
using PersistanceGeneric.IRepositories;
using PersistanceGeneric.Repositories;

namespace PersistanceGeneric.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Project> GetProjectsOrderByAsc()
        {
            return Context.Projects.OrderBy(x=>x.Title).ToList();
        }
    }
}
