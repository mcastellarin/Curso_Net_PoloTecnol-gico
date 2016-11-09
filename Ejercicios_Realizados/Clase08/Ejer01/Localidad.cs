using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    public class Localidad
    {
        private int _IDLocalidad;
        private string _Nombre;
        private Provincia _Provincia;

        public int IDLocalidad
        {
            get
            {
                return _IDLocalidad;
            }

            set
            {
                _IDLocalidad = value;
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

        public Provincia Provincia
        {
            get
            {
                return _Provincia;
            }

            set
            {
                _Provincia = value;
            }
        }
    }
}
