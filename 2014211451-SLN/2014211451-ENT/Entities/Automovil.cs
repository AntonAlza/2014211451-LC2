﻿using _2014211451_ENT.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014211451_ENT.Entities
{
    public class Automovil : Carro
    {

        public TipoAuto TipoAuto { get; set; }



        public Automovil(TipoAuto tipoAuto)
        {

            TipoAuto = tipoAuto;
        }

        public Automovil()
        {
            TipoAuto = TipoAuto.NoDefinido;
        }
    }
}