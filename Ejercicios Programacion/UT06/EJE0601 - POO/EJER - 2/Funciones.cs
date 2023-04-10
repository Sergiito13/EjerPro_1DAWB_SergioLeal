using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    class Funciones
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("");
            Console.WriteLine(" =================menu==================");
            Console.WriteLine(" |-------------------------------------|");
            Console.WriteLine(" | 1.- Añadir Producto                 |");
            Console.WriteLine(" | 2.- Existe Producto                 |");
            Console.WriteLine(" | 3.- Llenar máquina                  |");
            Console.WriteLine(" | 4.- Salir                           |");
            Console.WriteLine(" |-------------------------------------|");
            Console.WriteLine(" =======================================");
        }

        public static int PedirOpcionMenu()
        {
            // Declaramos las variables
            int opcionMenu = 0;

            Console.WriteLine("");
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine(" Dime una opcion para el menu");
            while (!int.TryParse(Console.ReadLine(), out opcionMenu) || (opcionMenu < 1) || opcionMenu > 4)
            {
                Console.WriteLine("Error la opcion elegida no es correcta");
            }
            return opcionMenu;
        }

        public static bool OpcionesMenu()
        {
            // Declaramos las variables
            bool salir = false;
            List<StockMaquina> maquina = new List<StockMaquina>();

            do
            {
                MostrarMenu();
                int opcionMenu = PedirOpcionMenu();

                Console.WriteLine("");
                switch (opcionMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Haz elegido la opción 1. ");
                        maquina = StockMaquina.AñadirProductoMaquinaExpendedora(maquina);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Haz elegido la opción 2. ");
                        
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Haz elegido la opción 3. ");
                        
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa...");
                        salir = true;
                        break;
                }
            } while (!salir);


            return salir;
        }

    }
}
