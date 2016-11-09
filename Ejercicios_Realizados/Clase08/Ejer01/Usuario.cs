using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    public class Usuario
    {
        private string _Login, _Password;
        private int _IntentosErroneos;
        private DateTime _PasswordExpiration, _LastSuccessLogin, _LastFailLogin;
        private Boolean _MustChangePassword, _EnforceExpiration, _EnforceStrong, _Enabled;
        private HashSet<Perfil> _Perfiles;
        private Perfil _PerfilDefault;
        private Empleado _Empleado;

        public string Login
        {
            get
            {
                return _Login;
            }

            set
            {
                _Login = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }

        public int IntentosErroneos
        {
            get
            {
                return _IntentosErroneos;
            }

            set
            {
                _IntentosErroneos = value;
            }
        }

        public DateTime PasswordExpiration
        {
            get
            {
                return _PasswordExpiration;
            }

            set
            {
                _PasswordExpiration = value;
            }
        }

        public DateTime LastSuccessLogin
        {
            get
            {
                return _LastSuccessLogin;
            }

            set
            {
                _LastSuccessLogin = value;
            }
        }

        public DateTime LastFailLogin
        {
            get
            {
                return _LastFailLogin;
            }

            set
            {
                _LastFailLogin = value;
            }
        }

        public bool MustChangePassword
        {
            get
            {
                return _MustChangePassword;
            }

            set
            {
                _MustChangePassword = value;
            }
        }

        public bool EnforceExpiration
        {
            get
            {
                return _EnforceExpiration;
            }

            set
            {
                _EnforceExpiration = value;
            }
        }

        public bool EnforceStrong
        {
            get
            {
                return _EnforceStrong;
            }

            set
            {
                _EnforceStrong = value;
            }
        }

        public bool Enabled
        {
            get
            {
                return _Enabled;
            }

            set
            {
                _Enabled = value;
            }
        }

        public HashSet<Perfil> Perfiles
        {
            get
            {
                return _Perfiles;
            }

            set
            {
                _Perfiles = value;
            }
        }

        public Perfil PerfilDefault
        {
            get
            {
                return _PerfilDefault;
            }

            set
            {
                _PerfilDefault = value;
            }
        }

        public Empleado Empleado
        {
            get
            {
                return _Empleado;
            }

            set
            {
                _Empleado = value;
            }
        }
    }
}
