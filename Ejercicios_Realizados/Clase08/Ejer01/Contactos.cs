using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    public class Contactos
    {
        private int _IDContacto;
        private string _Dato, _Comentario;
        private TipoContacto _TipoContacto;

        public int IDContacto
        {
            get
            {
                return _IDContacto;
            }

            set
            {
                _IDContacto = value;
            }
        }

        public string Dato
        {
            get
            {
                return _Dato;
            }

            set
            {
                _Dato = value;
            }
        }

        public string Comentario
        {
            get
            {
                return _Comentario;
            }

            set
            {
                _Comentario = value;
            }
        }

        public TipoContacto TipoContacto
        {
            get
            {
                return _TipoContacto;
            }

            set
            {
                _TipoContacto = value;
            }
        }
    }
}
