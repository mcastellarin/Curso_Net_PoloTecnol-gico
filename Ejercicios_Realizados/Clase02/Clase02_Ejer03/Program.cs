using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;
            bool anioMultiploCuatro, anioMultiploCien, anioMultiploCuatrocientos, anioBisiesto;

            Console.WriteLine("Ingrese un año\n");
            bool result = Int32.TryParse(Console.ReadLine(), out anio);
            Console.WriteLine("\n");

            if (result)
            { 
                anioMultiploCuatro = (anio % 4 == 0);
                anioMultiploCien = (anio % 100 == 0);
                anioMultiploCuatrocientos = (anio % 400 == 0);
                anioBisiesto = DateTime.IsLeapYear(anio);

                if (anioMultiploCuatro)
                    Console.WriteLine("{0} multiplo de cuatro\n", anio);
                else
                    Console.WriteLine("{0} no es multiplo de cuatro\n", anio);

                if (anioMultiploCien)
                   Console.WriteLine("{0} es multiplo de cien\n", anio);
                else
                    Console.WriteLine("{0} no multiplo de cien\n", anio);

                if (anioMultiploCuatrocientos)
                  Console.WriteLine("{0} multiplo de cuatrocientos\n", anio);
                else
                  Console.WriteLine("{0} no es multiplo de cuatrocientos\n", anio);

                if (anioBisiesto)
                    Console.WriteLine("{0} bisiesto\n", anio);
                else
                    Console.WriteLine("{0} no es bisiesto\n", anio);
            }
            Console.ReadKey();

        }
    }
}
