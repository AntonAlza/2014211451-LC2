using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014211451_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {

        IAsientoRepository Asientos { get; }
        IAutomovilRepository Automoviles { get; }
        IBusRepository Buses { get; }
        ICinturonRepository Cinturones { get; }
        IEnsambladoraRepository Ensambladoras { get; }
        ILlantaRepository Llantas { get; }
        IPropietarioRepository Propietarios { get; }
        IParabrisasRepository Parabrisas { get; }
        IVolanteRepository Volantes { get; }


        int SaveChanges();
    }
}
