﻿using _2014214451_ENT;
using _2014214451_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _2014214451_PER.Repositories
{
    public class LlantaRepository : Repository<Llanta>, ILlantaRepository
    {
        public LlantaRepository(EnsambladoraDbContext context) : base(context)
        {
        }
    }
}
