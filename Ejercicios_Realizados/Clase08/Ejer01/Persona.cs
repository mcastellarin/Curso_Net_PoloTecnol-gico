using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    public class Persona
    {
        private Guid _IDPersona;
        private string _Apellidos, _Nombres,_Domicilio, _AmpliacionDomicilio, _Documento, _CodigoPostal;
        private DateTime _Nacimiento;
        private Sexos _Sexo;
        private TipoDocumento _TipoDocumento;
        private Localidad _Localidad;
        private HashSet<Contactos> _InfoContacto;

        public enum Sexos { Femenino, Masculino };

    
        public Guid IDPersona
        {
            get
            {
                return _IDPersona;
            }

            set
            {
                _IDPersona = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
            }
        }

        public string Nombres
        {
            get
            {
                return _Nombres;
            }

            set
            {
                _Nombres = value;
            }
        }

        public string Domicilio
        {
            get
            {
                return _Domicilio;
            }

            set
            {
                _Domicilio = value;
            }
        }

        public string AmpliacionDomicilio
        {
            get
            {
                return _AmpliacionDomicilio;
            }

            set
            {
                _AmpliacionDomicilio = value;
            }
        }

        public string Documento
        {
            get
            {
                return _Documento;
            }

            set
            {
                _Documento = value;
            }
        }

        public string CodigoPostal
        {
            get
            {
                return _CodigoPostal;
            }

            set
            {
                _CodigoPostal = value;
            }
        }

        public DateTime Nacimiento
        {
            get
            {
                return _Nacimiento;
            }

            set
            {
                _Nacimiento = value;
            }
        }

        public Sexos Sexo
        {
            get
            {
                return _Sexo;
            }

            set
            {
                _Sexo = value;
            }
        }

        public TipoDocumento TipoDocumento
        {
            get
            {
                return _TipoDocumento;
            }

            set
            {
                _TipoDocumento = value;
            }
        }


        public Localidad Localidad
        {
            get
            {
                return _Localidad;
            }

            set
            {
                _Localidad = value;
            }
        }

        public HashSet<Contactos> InfoContacto
        {
            get
            {
                return _InfoContacto;
            }

            set
            {
                _InfoContacto = value;
            }
        }

       
    }
}
