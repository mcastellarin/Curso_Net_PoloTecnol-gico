﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_EF_Entidades
{
    public class Usuario
    {   
        public string Login { get; set; }
        public DateTime? FechaUltimoLogin { get; set; }
        public int? IntentosInvalidos { get; set; }
        public Perfil Perfil { get; set; }


    }
}
