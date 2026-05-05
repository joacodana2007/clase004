using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1_Clase004
{
    public class Serie : Contenido
    {
        private int cantidadTemporada;
        private int cantidadCapitulo;

        public int CantidadTemporada { get; set; }   
        public int CantidadCapitulo  { get; set; }

        public override string mostrarInformacion()
        {
            string mensaje = "La pelicula se llama" + Titulo;

            return mensaje;
        }
    }
}
