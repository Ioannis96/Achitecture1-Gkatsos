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
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Doctor> OrderDocByAge() => Context.Doctors.OrderBy(x => x.Age).ToList();

    }
}
