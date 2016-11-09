using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    public class Provincia
    {
        private char _IDProvincia;
        private string _Nombre;

        public char IDProvincia
        {
            get
            {
                return _IDProvincia;
            }

            set
            {
                _IDProvincia = value;
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
    }
}
