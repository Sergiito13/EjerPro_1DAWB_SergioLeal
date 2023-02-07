using Ejercicio2Fichero;

namespace Ejercicio2Ficheros
{
    class Utils
    {

        public static void MostrarMenu() // ESTA FUNCION MOSTRARA EL MENU
        {

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("-               Este es el menu                   -");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("- ||||||||||||||||||||||||||||||||||||||||||||||||-");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("-|   1. Crear Fichero                            |-");
            Console.WriteLine("-|   2. Introducir valores al fichero            |-");
            Console.WriteLine("-|   3. Calcular el valor máximo                 |-");
            Console.WriteLine("-|   4. Calcular el valor mínimo                 |-");
            Console.WriteLine("-|   5- Calcular la media                        |-");
            Console.WriteLine("-|   6- Salir                                    |-");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");


        }

        public static int PedirNumeroMenu()
        {
            // Declaramos las variables
            int numeroUsu = 0;

            Console.WriteLine("Dime una opcion:");
            while (!int.TryParse(Console.ReadLine(), out numeroUsu) || (numeroUsu < 1) || (numeroUsu > 6))
            {
                Console.WriteLine("ERROR! La opcion a introducir debe ser entre 1 o 6");
            }
            return numeroUsu;

        }

        public static bool Menu(int OpcionMenu) // ESTA FUNCION 
        {
            // Declaramos las variables
            bool Salir = false;

            switch (OpcionMenu)
            {
                case 1: Fichero.CrearFichero(); break;
                case 2: Fichero.IntroducirValoresFichero(); break;
                case 3: Fichero.ValorMaximoFichero(); break;
                case 4: Fichero.ValorMinimoFichero(); break;
                case 5: Fichero.CalcularMediaFichero(); break;
                case 6: Console.WriteLine("Haz seleccionado la opcion de salir. ADIOS"); 
                        Salir = true; 
                        return Salir; 
                        break;
            }
            return Salir;
        }


    }
}
