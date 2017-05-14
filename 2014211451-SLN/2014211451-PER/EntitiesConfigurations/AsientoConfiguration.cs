using _2014211451_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014211451_PER.EntitiesConfigurations
{
    public class AsientoConfiguration : EntityTypeConfiguration<Asiento>
    {
        public AsientoConfiguration()
        {
      
            ToTable("Asientos");
            HasKey(a => a.AsientoId);





        
            HasRequired(a => a.Cinturon)
                .WithRequiredPrincipal(a => a.Asiento);
        }
    }
}
