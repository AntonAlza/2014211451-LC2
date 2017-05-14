﻿using _2014211451_ENT.Entities;
using _2014211451_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014211451_PER.Repositories
{
    public class PropietarioRepository : Repository<Propietario>, IPropietarioRepository
    {
        private readonly AlzaPerezDbContext _Context;

        public PropietarioRepository(AlzaPerezDbContext context)
        {
         
            _Context = context;
        }

        private PropietarioRepository() : base()
        {

        }


        IEnumerable<Propietario> IPropietarioRepository.GetPropietarioByCarro(Carro carro, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Propietario> IPropietarioRepository.GetPropietarioByCarroAndTipoCarro(Carro carro, _2014211451_ENT.Enumerados.TipoCarro tipoCarro)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.Add(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.AddRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }

        Propietario IRepository<Propietario>.Get(int Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Propietario> IRepository<Propietario>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Propietario> IRepository<Propietario>.Find(System.Linq.Expressions.Expression<Func<Propietario, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.Update(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.UpdateRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.Delete(Propietario entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Propietario>.DeleteRange(IEnumerable<Propietario> entities)
        {
            throw new NotImplementedException();
        }
    }
}
