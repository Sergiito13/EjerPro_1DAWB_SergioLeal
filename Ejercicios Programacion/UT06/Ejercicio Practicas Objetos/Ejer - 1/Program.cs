using System;
using System.Collections.Generic;

namespace ejer1
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // Declaramos las variables
            List<Juego> juegos = new List<Juego>();
            int opcion = 0;
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------Menu--------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("- 1.- Añadir Juego                      -");
                Console.WriteLine("- 2.- Mostrar Lista de juegos           -");
                Console.WriteLine("- 3.- Salir                             -");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Dime una opcion del menu");
                while (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("ERROR !");
                }
                if ((opcion >= 1)||(opcion <= 2))
                {
                    switch (opcion)
                    {
                        case 1:
                            {
                                juegos = Juego.AñadirNuevoJuego(juegos);
                            }
                            ; break;
                        case 2:
                            {
                                Juego.MostrarLosJuegos(juegos);
                            }
                            ; break;
                        case 3: salir = true; 
                            break;    
                    }
                }  
            } while (!salir);
            

        }
    }
}
