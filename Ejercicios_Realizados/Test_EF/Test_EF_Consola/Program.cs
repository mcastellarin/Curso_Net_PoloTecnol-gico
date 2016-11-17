using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_EF_Datos;
using Test_EF_Entidades;

namespace Test_EF_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Test_EF_Context ctx = new Test_EF_Context();

            AppDomain.CurrentDomain.UnhandledException += (s, e) => ctx.Dispose();

            if (ctx.Database.Exists())
                Console.WriteLine("La base existe");

            //ctx.Database.Log()

            Console.ReadLine();

            Perfil p = ctx.Perfiles.FirstOrDefault();

            Console.WriteLine($" {p.Descripcion} ");

            Console.ReadLine();

            ctx.Dispose();
        }

    }
}
