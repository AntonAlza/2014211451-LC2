﻿using _2014211451_ENT.Entities;
using _2014211451_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014211451_PER.Repositories
{
    public class ParabrisasRepository : Repository<Parabrisas>, IParabrisasRepository
    {
        private readonly AlzaPerezDbContext _Context;

        public ParabrisasRepository(AlzaPerezDbContext context)
        {
         
            _Context = context;
        }

        private ParabrisasRepository() : base()
        {

        }

        void IRepository<Parabrisas>.Add(Parabrisas entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisas>.AddRange(IEnumerable<Parabrisas> entities)
        {
            throw new NotImplementedException();
        }

        Parabrisas IRepository<Parabrisas>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Parabrisas> IRepository<Parabrisas>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Parabrisas> IRepository<Parabrisas>.Find(System.Linq.Expressions.Expression<Func<Parabrisas, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisas>.Update(Parabrisas entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisas>.UpdateRange(IEnumerable<Parabrisas> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisas>.Delete(Parabrisas entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Parabrisas>.DeleteRange(IEnumerable<Parabrisas> entities)
        {
            throw new NotImplementedException();
        }
    }
}