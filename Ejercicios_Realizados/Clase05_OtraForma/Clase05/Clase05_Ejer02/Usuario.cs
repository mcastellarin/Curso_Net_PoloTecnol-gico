using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05_Ejer02
{
    public class Usuario
    {
        private string _nombreUsuario;
        private string _password;
        private DateTime _ultimoLogin;
        private int _intentosErroneos;

        public Usuario CrearUsuario(string u, string p)
        {
            this.NombreUsuario = u;
            this.Password = p;

            return this;

        }

        public string NombreUsuario
        {
            get
            {
                return _nombreUsuario;
            }

            set
            {
                _nombreUsuario = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        public DateTime UltimoLogin
        {
            get
            {
                return _ultimoLogin;
            }

            set
            {
                _ultimoLogin = value;
            }
        }

        public int IntentosErroneos
        {
            get
            {
                return _intentosErroneos;
            }

            set
            {
                _intentosErroneos = value;
            }
        }
        public Usuario()
        {
        	IntentosErroneos = 4;
        }
      
    }
}
