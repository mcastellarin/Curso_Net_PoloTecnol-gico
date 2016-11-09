using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    public class TipoContacto
    {
        private int _IDTipoContacto;
        private string _Descripcion, _RegExp;

        public int IDTipoContacto
        {
            get
            {
                return _IDTipoContacto;
            }

            set
            {
                _IDTipoContacto = value;
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

        public string RegExp
        {
            get
            {
                return _RegExp;
            }

            set
            {
                _RegExp = value;
            }
        }
    }
}
