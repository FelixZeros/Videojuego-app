using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    abstract class Personaje
    {
        public string Nombre { get; set; }
        public int Fuerza { get; set; }
        public int Inteligencia { get; set; }
        public int Defensa { get; set; }
        public int Armadura { get; set; }

        public int Vida { get; set; }

        public virtual int Atacar(Personaje personaje) {
            return Fuerza;
        }
        public virtual void Moverse() { }
        public virtual void Turno(Personaje personaje1) {


            double CalFuerza = 0.29;
            double CalInteligencia = 0.25;
            double CalDefensa = 0.26;
            double CalVida = 0.20;

            double TotalPersonaje1 = (Inteligencia * CalInteligencia) + (Defensa * CalDefensa)
                + (Fuerza * CalFuerza) + (Vida * CalVida);

            double TotalPersonaje2 = (personaje1.Inteligencia * CalInteligencia)
                + (personaje1.Defensa * CalDefensa) + (personaje1.Fuerza * CalFuerza)
                + (personaje1.Vida * CalVida);

            Console.WriteLine($"Media del {this.Nombre}: {TotalPersonaje1}");
            Console.WriteLine($"Media del {personaje1.Nombre}: {TotalPersonaje2}");


            if (TotalPersonaje1 > TotalPersonaje2)
            {
                this.Atacar(personaje1);
                Console.WriteLine($"{this.Nombre} ganó el turno y atacó primero.");

                if (this.Vida <= 0 && this.Vida < personaje1.Vida)
                {
                    Console.WriteLine($"{this.Nombre} se murió.");
                    Console.ReadKey();
                }
                else if (personaje1.Vida <= 0 && personaje1.Vida < this.Vida)
                {
                    Console.WriteLine($"{personaje1.Nombre} se murió.");
                    Console.ReadKey();
                }

                personaje1.Atacar(this);
            }
            else
            {
                personaje1.Atacar(this);
                Console.WriteLine($"{personaje1.Nombre} ganó el turno y atacó primero.");
                if (this.Vida <= 0 && this.Vida < personaje1.Vida)
                {
                    Console.WriteLine($"{this.Nombre} se murió.");
                    Console.ReadKey();
                }
                else if (personaje1.Vida <= 0 && personaje1.Vida < this.Vida)
                {
                    Console.WriteLine($"{personaje1.Nombre} se murió.");
                    Console.ReadKey();
                }
                this.Atacar(personaje1);
            }

           
        }
        public virtual void MostrarSalud() { }
    }
}
