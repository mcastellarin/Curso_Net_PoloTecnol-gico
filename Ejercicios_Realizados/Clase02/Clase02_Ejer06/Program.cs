using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clase02_Ejer06
{
    class Program
    {
        static void Main(string[] args)
        {
            int contPuntos = 0;
            string linea = null;

            StreamReader archivo = new StreamReader(@"C: \Users\MailenWin7\Desktop\Ejercicios_Curso_Net_Empleartec_2016\Clase02\Quijote.txt");

            while ((linea = archivo.ReadLine()) != null)
            {

                if (linea.Contains("."))
                    contPuntos++;  
            }

            System.Console.WriteLine("Cantidad de puntos {0}",contPuntos);
            archivo.Close();
           
            Console.ReadKey();
        }
    }
}
