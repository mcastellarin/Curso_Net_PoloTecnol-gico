using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05_Ejer02
{
    class Program
    {
        static void Main(string[] args)
        {
            Seguridad seg = new Seguridad();


            Console.WriteLine("Ingrese un nombre de usuario\n");
            string usuario = Console.ReadLine();

            Console.WriteLine("Ingrese una contraseña\n");
            string contrasenia = Console.ReadLine();

            Usuario user = seg.Login(usuario, contrasenia);


            //Usuario user = seg.Login("bsimpson", "123456");

            if (user == null)
                Console.WriteLine(seg.ErrorInfo);
            else
                Console.WriteLine("Usuario:\n{0}\nContraeña:\n{1}", user.NombreUsuario,user.Password);
            Console.ReadKey();

        }
    }
}
