using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Test_EF_Entidades;
using System.Data.Entity.ModelConfiguration;


namespace Test_EF_Datos
{
    public class Test_EF_Context : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Perfil> Perfiles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConfiguraPerfil());
        }

    }

    public class ConfiguraPerfil : EntityTypeConfiguration<Perfil>
    {
        public ConfiguraPerfil()
        {
            this.HasKey(p => p.ID_Perfil);
            this.Property(p => p.ID_Perfil).HasColumnName("ID_Perfil");
          
        }
    }
}
