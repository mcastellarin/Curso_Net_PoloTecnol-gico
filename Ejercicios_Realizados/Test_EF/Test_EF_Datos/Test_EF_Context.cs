using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Test_EF_Entidades;
using System.Data.Entity.ModelConfiguration;

using System.IO;

namespace Test_EF_Datos
{
    public class Test_EF_Context : DbContext
    {

        //public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Perfil> Perfiles { get; set; }
        private StreamWriter _w;

        public Test_EF_Context()
        {
            _w = File.CreateText(@"D:\ppp.log");
            this.Database.Log = (s) => _w.WriteLine(s);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConfiguraPerfil());
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _w.Flush();
            _w.Close();
        }
    }

    public class ConfiguraPerfil : EntityTypeConfiguration<Perfil>
    {
        public ConfiguraPerfil()
        {
            this.HasKey(p => p.ID_Perfil);
            this.Property(p => p.ID_Perfil).HasColumnName("ID_Perfil");
            this.ToTable("Perfiles");



        }
    }
}
