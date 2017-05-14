﻿using _2014211451_ENT.Entities;
using _2014211451_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014211451_PER.Repositories
{
    public class EnsambladoraRepository : Repository<Ensambladora>, IEnsambladoraRepository
    {
        private readonly AlzaPerezDbContext _Context;

        public EnsambladoraRepository(AlzaPerezDbContext context)
        {
           
            _Context = context;
        }

        private EnsambladoraRepository() : base()
        {

        }

        void IRepository<Ensambladora>.Add(Ensambladora entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Ensambladora>.AddRange(IEnumerable<Ensambladora> entities)
        {
            throw new NotImplementedException();
        }

        Ensambladora IRepository<Ensambladora>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Ensambladora> IRepository<Ensambladora>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Ensambladora> IRepository<Ensambladora>.Find(System.Linq.Expressions.Expression<Func<Ensambladora, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Ensambladora>.Update(Ensambladora entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Ensambladora>.UpdateRange(IEnumerable<Ensambladora> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Ensambladora>.Delete(Ensambladora entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Ensambladora>.DeleteRange(IEnumerable<Ensambladora> entities)
        {
            throw new NotImplementedException();
        }
    }
}