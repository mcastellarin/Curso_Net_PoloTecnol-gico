using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer02
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                //	Para probar la funcion Ordenar dentro de Sort

                seg.Usuarios.Dump();
                seg.Usuarios.Sort(Ordenar);
                seg.Usuarios.Dump();
            */

            /*
            Usuario user = seg.Login("bsimpson", "123456");

            if (user == null)
                Console.WriteLine(seg.ErrorInfo);
            else
                Console.WriteLine("Nombre usuario: {0}\nContraseña: {1}", user.Login, user.Password);

    */
            Seguridad seg = new Seguridad();

            Console.WriteLine("Datos de usuario a crear/iniciar sesion:\n");

            Console.WriteLine("\nIngrese nombre de usuario:\n");
            string nu = Console.ReadLine();

            Console.WriteLine("\nIngrese contraseña:\n");
            string c = Console.ReadLine();

            bool respuesta = seg.CrearUsuario(nu,c);

            if (respuesta)        
                Console.WriteLine("\nCreado con éxito");  
            else
                Console.WriteLine("\nYa existe un usuario con ese alias");

            Usuario u = seg.Login(nu, c);

            while (u == null)
            {
                    Console.WriteLine(seg.ErrorInfo);
                    if (seg.ErrorInfo.Equals("Credenciales invalidas"))
                    {
                        Console.WriteLine("Ingrese contraseña\n");
                        c = Console.ReadLine();
                        u = seg.Login(nu, c);
                    }
            }

            Console.WriteLine("Logueado al sistema");
            Console.ReadKey();
        }
    }
}
