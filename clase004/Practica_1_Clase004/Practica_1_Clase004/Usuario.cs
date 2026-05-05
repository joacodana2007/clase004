using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Clase004
{
    public class Usuario
    {
        private string nombreDeUsuario;
        private string claveUsuario;

        public string NombreDelUsuario { get { return nombreDeUsuario; } set { nombreDeUsuario = value; } }
        public string ClaveUsuario     { get { return claveUsuario;    } set { claveUsuario    = value; } }

    }
}
