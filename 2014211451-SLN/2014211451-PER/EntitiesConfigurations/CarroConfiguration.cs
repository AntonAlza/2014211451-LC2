using _2014211451_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014211451_PER.EntitiesConfigurations
{
    public class CarroConfiguration : EntityTypeConfiguration<Carro>
    {
        public CarroConfiguration()
        {
      
            ToTable("Carros");
            HasKey(a => a.CarroId);
         
            Property(p => p.NumSerieChasis).IsRequired();






   
            HasMany(a => a.Llantas)
                .WithRequired(a => a.Carro);


            HasMany(a => a.Asientos)
                .WithRequired(a => a.Carro);


            HasRequired(a => a.Propietario)
                .WithMany(a => a.Carros);


            HasRequired(a => a.Volante)
                .WithRequiredPrincipal(a => a.Carro);


            HasMany(a => a.Parabrisas)
                .WithRequired(a => a.Carro);


            HasRequired(a => a.Ensambladora)
                .WithMany(a => a.Carros);



            Map<Bus>(m => m.Requires("Discriminator").HasValue("Bus"));
            Map<Automovil>(m => m.Requires("Discriminator").HasValue("Automovil"));

        }
    }
}
