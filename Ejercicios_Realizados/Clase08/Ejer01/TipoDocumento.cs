using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01
{
    public class TipoDocumento
    {
        private int _IDTipoDocumento;
        private string _Descripcion;

        //public enum TipoDocumentos { DNI, CI, LC };

        public int IDTipoDocumento
        {
            get
            {
                return _IDTipoDocumento;
            }

            set
            {
                _IDTipoDocumento = value;
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
