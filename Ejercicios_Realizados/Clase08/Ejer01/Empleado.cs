using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    public class Empleado: Persona
    {
        private string _Legajo, _CUIT;
        //private Persona _Persona;
        private Byte[] _Foto;
        private DateTime _FechaIngreso, _FechaEgreso;
        private CategoriaEmpleado _Categoria;

        public string Legajo
        {
            get
            {
                return _Legajo;
            }

            set
            {
                _Legajo = value;
            }
        }

        public string CUIT
        {
            get
            {
                return _CUIT;
            }

            set
            {
                _CUIT = value;
            }
        }

        /*
        public Persona Persona
        {
            get
            {
                return _Persona;
            }

            set
            {
                _Persona = value;
            }
        }
        */
        public byte[] Foto
        {
            get
            {
                return _Foto;
            }

            set
            {
                _Foto = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return _FechaIngreso;
            }

            set
            {
                _FechaIngreso = value;
            }
        }

        public DateTime FechaEgreso
        {
            get
            {
                return _FechaEgreso;
            }

            set
            {
                _FechaEgreso = value;
            }
        }

        public CategoriaEmpleado Categoria
        {
            get
            {
                return _Categoria;
            }

            set
            {
                _Categoria = value;
            }
        }
    }
}
