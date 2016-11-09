using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejer05
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaHoy, fechaNacimiento;
            fechaHoy = DateTime.Now;
            fechaNacimiento = new DateTime(1993, 07, 20);

            Console.WriteLine("La fecha es {0} {1} de {2} del año {3}", fechaHoy.ToString("dddd"), fechaHoy.ToString("dd"), fechaHoy.ToString("MMMM"),fechaHoy.ToString("yyyy"));

            Console.WriteLine("La fecha de nacimiento es {0} {1} de {2} del año {3}", fechaNacimiento.ToString("dddd"), fechaNacimiento.ToString("dd"), fechaNacimiento.ToString("MMMM"), fechaNacimiento.ToString("yyyy"));
            Console.ReadKey();

        }
    }
}
