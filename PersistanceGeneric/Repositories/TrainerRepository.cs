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
    public class TrainerRepository:GenericRepository<Trainer>,ITrainerRepository
    {
        public TrainerRepository(ApplicationDbContext context):base(context)
        {

        }
        public IEnumerable<Trainer> GetProjectsOrderByRev()
        {
            return Context.Trainers.OrderBy(x => x.Name).Reverse().ToList();
        }
    }
}
