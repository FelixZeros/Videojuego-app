using Videojuego.Controller;

namespace Videojuego.View
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PJController controller = new PJController();


            

            controller.attack(1, 2);

           /* while (controlador)
            bool controlador = true;
            {
                controlador = guerrero1.Turno(guerrero2);

                if (controlador == true)
                {
                    guerrero1.MostrarSalud();
                    guerrero2.MostrarSalud();
                    Console.WriteLine();
                    Console.ReadKey();
                }



            }*/


        }
    }
}