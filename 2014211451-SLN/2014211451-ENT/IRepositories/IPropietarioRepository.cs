using _2014211451_ENT.Entities;
using _2014211451_ENT.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014211451_ENT.IRepositories
{
    public interface IPropietarioRepository : IRepository<Propietario>
    {
       
        IEnumerable<Propietario> GetPropietarioByCarro(Carro carro, int pageIndex, int pageSize);

   
        IEnumerable<Propietario> GetPropietarioByCarroAndTipoCarro(Carro carro, TipoCarro tipoCarro);
    }
}
