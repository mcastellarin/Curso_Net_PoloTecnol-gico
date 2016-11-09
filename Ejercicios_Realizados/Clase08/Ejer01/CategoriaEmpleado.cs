using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    public class CategoriaEmpleado
    {
        private int _IDCategoriaEmpleado;
        private string _Nombre, _Descripcion;

        
        public int IDCategoriaEmpleado
        {
            get
            {
                return _IDCategoriaEmpleado;
            }

            set
            {
                _IDCategoriaEmpleado = value;
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
