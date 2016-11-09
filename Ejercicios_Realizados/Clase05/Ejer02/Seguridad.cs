using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer02
{
    public class Seguridad
    {
        public string ErrorInfo { get; set; }

        private List<Usuario> Usuarios { get; set; }

        private string _uid;

        public bool CrearUsuario(string nombUsu, string contUsu)
        {
            _uid = nombUsu;

            Usuario user = Usuarios.Find(BuscarUsuarioValido);

            if (user == null)
            {
                if (contUsu != null)
                {
                    Usuarios.Add(new Usuario { Login = nombUsu,Password = contUsu, IntentosErroneos = 0});
                    Console.WriteLine("\nUsuario:\n{0}\n{1}",Usuarios.Last().Login, Usuarios.Last().Password);
                    return true;
                }
            }

            return false;
        }

       

        public Usuario Login(string uid, string pwd)
        {
            ErrorInfo = null;

            _uid = uid;
            Usuario user = Usuarios.Find(BuscarUsuarioValido);

            if (user.Password == pwd)
            {
                user.UltimoLogin = DateTime.Now;

                if (user.IntentosErroneos > 3)
                {
                    ErrorInfo = "Bloqueado por intentos excesivos";
                    return null;
                }
                
                return user;
            }

            user.IntentosErroneos++;
    
            ErrorInfo = "Credenciales invalidas";
            return user;
        }

        private bool BuscarUsuarioValido(Usuario u)
        {
            if (u.Login == _uid)
                return true;

            return false;
        }

        int Ordenar(Usuario u1, Usuario u2)
        {
            //	multiplicar por -1 para ordenar de manera descendente
            return u1.Login.CompareTo(u2.Login);
        }

        public Seguridad()
        {
            Usuarios = new List<Usuario>()
            {
                new Usuario() { Login = "hsimpson", Password = "12345" },
                new Usuario() { Login = "mburns", Password = "12345" },
                new Usuario() { Login = "msimpson", Password = "12345" },
                new Usuario() { Login = "mbouvier", Password = "12345" },
                new Usuario() { Login = "nflanders", Password = "12345" },
                new Usuario() { Login = "bsimpson", Password = "123456", IntentosErroneos = 4 }
            };
        }

    }
}
