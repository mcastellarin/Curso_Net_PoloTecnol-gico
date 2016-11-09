using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02_Ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero;
            Console.WriteLine("Ingrese un nro entero:\n");
            bool resul = Int32.TryParse(Console.ReadLine(), out entero);

            if (resul)
            {
                int digito, i, sumaAcumulada;
                digito = i = sumaAcumulada = 0;
                int[] digitos = new int[50];

                while (entero > 0)
                {
                    digito = entero % 10;
                    digitos[i] = digito;
                    entero = entero / 10;
                    if (entero < 10)
                    {
                        ++i;
                        digitos[i] = entero;
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }

                for (int j = 0; j <= i; j++)
                {
                    sumaAcumulada += digitos[j];
                }
                Console.WriteLine("El acumulado del nro es {0}", sumaAcumulada);
                Console.ReadKey();
            }
            else
                Console.WriteLine("No se ha ingresado un numero");
            Console.ReadKey();
        }
    }
}
