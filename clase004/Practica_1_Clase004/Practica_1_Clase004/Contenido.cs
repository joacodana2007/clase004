using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Clase004
{
    public  abstract class Contenido
    {
        private string titulo;
        private int lanzamiento;
        private int duracion;
        private Genero genero;
        private Director director;
        private List<Actor> listaActores;

        public string Titulo            { get { return titulo;       }  set { titulo = value;       } }
        public int Lanzamiento          { get { return lanzamiento;  }  set { lanzamiento = value;  } }
        public int Duracion             { get { return duracion;     }  set { duracion = value;     } }
        public Genero Genero            { get { return genero;       }  set { genero = value;       } }
        public Director Director        { get { return director;     }  set { director = value;     } }
        public List<Actor> ListaActores { get { return listaActores; }  set { listaActores = value; } }

        public abstract string mostrarInformacion();

        public Contenido() { ListaActores = new List<Actor>(); } 
    }
}
