using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Clase004
{
    public class Actor
    {
        private string nombreCompleto;
        private string añoNacimiento;
        private string nacionalidad;

        public string NombreCompleto { get { return nombreCompleto; } set { nombreCompleto = value; } }
        public string AñoNacimiento  { get { return añoNacimiento;  }  set { añoNacimiento = value;   } }
        public string Nacionalidad  { get  { return nacionalidad;   }   set { nacionalidad = value;     } } 
    }
}
