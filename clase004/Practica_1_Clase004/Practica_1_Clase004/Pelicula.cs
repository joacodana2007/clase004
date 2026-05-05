using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Clase004
{
    public class Pelicula : Contenido
    {
        private Clasificacion clasificacion;


        public override string mostrarInformacion()
        {
            string mensaje = "La pelicula se llama" + Titulo + "su genero es" + Genero + "su director es:" + Director ;

            return mensaje;
        }

    }


    public enum Clasificacion
    {
        ATP,
        MASDIECIOCHO,
        MASDIECISEIS,
        MASTRECE
    }

    
}
