using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videojuego.Models;

namespace Videojuego.Controller
{
    public class PJController
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
            Fuerza = 30,
            Espada = 69,
            Armadura = 20,
            Defensa = 20,
            Inteligencia = 34,
            Nombre = "Juan"
        };


        public void attack(int PJAtaque, int PJRecibe)
        {

            if(PJAtaque == 1)
            {
                int daño = guerrero1.Atacar(guerrero2);

                Console.WriteLine($"Se ha realizado {daño} de daño");

                guerrero2.Vida -= daño;

                Console.WriteLine($"Su vida es: {guerrero2.Vida}");

            }
            else
            {
                int daño = guerrero2.Atacar(guerrero1);

                Console.WriteLine($"Se ha realizado {daño} de daño");

                guerrero1.Vida -= daño;

                Console.WriteLine($"Su vida es: {guerrero1.Vida}");
            }

        }
    }
}
