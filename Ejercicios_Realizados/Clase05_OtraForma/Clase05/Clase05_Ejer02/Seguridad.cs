using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05_Ejer02
{
    public class Seguridad
    {
        private string _errorInfo;
        private List<Usuario> _usuarios;
        private string _usuario;

        public string ErrorInfo
        {
            get
            {
                return _errorInfo;
            }

            set
            {
                _errorInfo = value;
            }
        }

        public List<Usuario> Usuarios
        {
            get
            {
                return _usuarios;
            }

            set
            {
                _usuarios = value;
            }
        }

        public Seguridad()
        {
            Usuarios = new List<Usuario>()
            {
                new Usuario() { NombreUsuario = "hsimpson", Password = "12345" },
                new Usuario() { NombreUsuario = "mburns", Password = "12345" },
                new Usuario() { NombreUsuario = "msimpson", Password = "12345" },
                new Usuario() { NombreUsuario = "mbouvier", Password = "12345" },
                new Usuario() { NombreUsuario = "nflanders", Password = "12345" },
                new Usuario() { NombreUsuario = "bsimpson", Password = "123456", IntentosErroneos = 3 }
            };
        }

        public Usuario Login(string uid, string pwd)
        {
            ErrorInfo = null;

            _usuario = uid;

            Usuario user = Usuarios.Find(BuscarUsuarioValido);

            if (user == null)
            {
                if (pwd != null)

                {
                    Usuario u = new Usuario();
                    Usuario usuarioCreado = u.CrearUsuario(uid, pwd);
                    Usuarios.Add(usuarioCreado);
                    return Usuarios.Last();
                } 

                 
            } 
            else if (user.Password == pwd)
            {
                if (user.IntentosErroneos > 3)
                {
                    ErrorInfo = "Bloqueado por intentos excesivos";
                    return null;
                }

                return user;
            }

            ErrorInfo = "Credenciales invalidas";
            return null;
  
       }

       private bool BuscarUsuarioValido(Usuario u)
       {
        if (u.NombreUsuario == _usuario)
            return true;

        return false;
       }
    }
}
