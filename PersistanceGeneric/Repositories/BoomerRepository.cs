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
    internal class BoomerRepository : GenericRepository<Boomer>, IBoomerRepository
    {
        public BoomerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Boomer> GetBoomerOrderBy() => Context.Boomers.OrderBy(x => x.Name).ToList();
    }
}
    

