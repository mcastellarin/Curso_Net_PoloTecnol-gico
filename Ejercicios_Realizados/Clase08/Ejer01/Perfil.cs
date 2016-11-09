using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    public class Perfil
    {
        private Guid _IDPerfil;
        private string _Nombre, _Descripcion;

       
        public Guid IDPerfil
        {
            get
            {
                return _IDPerfil;
            }

            set
            {
                _IDPerfil = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }
    }
}
