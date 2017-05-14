using _2014211451_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014211451_PER.EntitiesConfigurations
{
    public class VolanteConfiguration : EntityTypeConfiguration<Volante>
    {
        public VolanteConfiguration()
        {
            
            ToTable("Volantes");
            HasKey(a => a.VolanteId);
        }
    }
}
