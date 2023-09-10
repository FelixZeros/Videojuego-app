namespace Videojuego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personaje guerrero1 = new Guerrero()
            {
                Vida = 500,
                Fuerza = 28,
                Espada = 83,
                Armadura = 30,
                Defensa = 23,
                Inteligencia = 40,
                Nombre = "Felix"
            };
            Personaje guerrero2 = new Guerrero()
            {
                Vida = 600,
                Fuerza = 44,
                Espada = 69,
                Armadura = 20,
                Defensa = 20,
                Inteligencia = 34,
                Nombre = "Juan"
            };

            bool controlador = true;

            while (controlador)
            {
                guerrero1.Turno(guerrero2);

                guerrero1.MostrarSalud();
                guerrero2.MostrarSalud();

                Console.WriteLine();
                Console.ReadKey();
            }

            
        }
    }
}