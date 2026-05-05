namespace Practica_1_Clase004
{
    internal class Program
    {
         static void Main(string[] args)
        {
            Genero unGenero = new Genero();
            Director unDirector = new Director();
            Pelicula unPelicula = new Pelicula();
            Actor unActor = new Actor();

            unGenero.NombreGenero = "Suspenso\n";

            unDirector.NombreCompleto = "Joaquin Cambas\n";

            unPelicula.Titulo = "saw\n";

            unActor.NombreCompleto = "Guillermo Franchela\n";

            unPelicula.Director = unDirector;
            unPelicula.Genero = unGenero;
            unPelicula.ListaActores.Add(unActor);

            Console.WriteLine("la pelicula se llama:" + unPelicula.Titulo + "el director es: " + unPelicula.Director.NombreCompleto + " el genero es:" + unPelicula.Genero.NombreGenero);
            Console.WriteLine("El actor principal es:" + unPelicula.ListaActores[0].NombreCompleto);


        }
    }
}
