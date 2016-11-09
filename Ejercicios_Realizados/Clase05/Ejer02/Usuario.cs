using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer02
{
    public class Usuario
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public DateTime UltimoLogin { get; set; }

        public int IntentosErroneos { get; set; }

    }
}
