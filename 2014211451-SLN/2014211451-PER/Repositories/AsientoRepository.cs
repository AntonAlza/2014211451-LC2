using _2014211451_ENT.Entities;
using _2014211451_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014211451_PER.Repositories
{
    public class AsientoRepository : Repository<Asiento>, IAsientoRepository
    {
        private readonly AlzaPerezDbContext _Context;
        private AsientoRepository() : base()
        {

        }

        public AsientoRepository(AlzaPerezDbContext context)
        {
            _Context = context;
        }

        void IRepository<Asiento>.Add(Asiento entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.AddRange(IEnumerable<Asiento> entities)
        {
            throw new NotImplementedException();
        }

        Asiento IRepository<Asiento>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Asiento> IRepository<Asiento>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Asiento> IRepository<Asiento>.Find(System.Linq.Expressions.Expression<Func<Asiento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.Update(Asiento entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.UpdateRange(IEnumerable<Asiento> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.Delete(Asiento entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.DeleteRange(IEnumerable<Asiento> entities)
        {
            throw new NotImplementedException();
        }
    }
}
