using _2014211451_ENT.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014211451_ENT.Entities
{
    public class Bus : Carro
    {


        public TipoBus TipoBus { get; set; }



        public Bus(TipoBus tipoBus)
        {
 
            TipoBus = tipoBus;
        }

        public Bus()
        {
            TipoBus = TipoBus.NoDefinido;
        }
    }
}
