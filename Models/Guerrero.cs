using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego.Models
{
    public class Guerrero : Personaje
    {
        public int Espada;

        public override int Atacar(Personaje personaje)
        {
            int daño = Espada + Fuerza;

            if (personaje.Defensa > 0 && personaje.Armadura > 0)
            {
                int defensaTotal = personaje.Defensa + personaje.Armadura;

                if (defensaTotal < daño)
                {
                    daño = daño - defensaTotal;


                    personaje.Vida = personaje.Vida - daño;
                }
            }
            else
            {
                personaje.Vida = personaje.Vida - daño;
            }

            return daño;
        }

        public override void MostrarSalud()
        {
            Console.WriteLine($"La vida del personaje {Nombre} es: {Vida}");
        }
    }
}
