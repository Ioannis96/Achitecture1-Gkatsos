using Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceGeneric.IRepositories
{
    public interface IBoomerRepository : IGenericRepository<Boomer>
    {
        IEnumerable<Boomer> GetBoomerOrderBy();

    }
}
