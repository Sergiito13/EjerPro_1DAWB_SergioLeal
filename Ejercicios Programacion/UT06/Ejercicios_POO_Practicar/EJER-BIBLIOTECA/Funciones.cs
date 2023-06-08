namespace ejerbiblioteca
{
    internal class Funciones
    {
        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════╗");
            Console.WriteLine("║ ♦ ¡Bienvenido al menú! ♦ ║");
            Console.WriteLine("╠══════════════════════════╣");
            Console.WriteLine("╠══════════════════════════╣");
            Console.WriteLine("║ 1.- Agregar libros       ║");
            Console.WriteLine("║ 2.- Buscar libros        ║");
            Console.WriteLine("║ 3.- Eliminar libros      ║");
            Console.WriteLine("║ 4.- Mostrar libros       ║");
            Console.WriteLine("║ 5.- Salir                ║");
            Console.WriteLine("╚══════════════════════════╝");
        }
        public static int PedirNumeroOpcionMenu()
        {
            // Declaramos las variables
            int numeroUser = 0;
            bool salir = false;

            do
            {
                Console.WriteLine("Dime una opción para el menu");
                while ((!int.TryParse(Console.ReadLine(), out numeroUser)))
                {
                    Console.WriteLine("Error ! La opción no es valida");
                }

                salir = true;

            } while (!salir);
            return numeroUser;
        }

        public static bool PedirRespuestaSeguir()
        {
            //Declaremos las variables
            bool correcto = false, seguir = false;

            do
            {
                Console.WriteLine("¿Quieres añadir otro libro? [si | no]");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta == "si")
                {
                    seguir = true;
                    correcto = true;
                }
                else if (respuesta == "no")
                {
                    seguir = false;
                    correcto = true;
                    Console.WriteLine("Has elegido no añadir más libros");
                }
                else
                {
                    Console.WriteLine("Error! La respuesta debe ser 'si' o 'no'");
                }

            } while (!correcto);
            return seguir;
        }

        public static void MostrarOpcionesBuscar()
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════╗");
            Console.WriteLine("║ ♦ Elige la busqueda ♦    ║");
            Console.WriteLine("╠══════════════════════════╣");
            Console.WriteLine("╠══════════════════════════╣");
            Console.WriteLine("║ 1.- Busqueda por titulo  ║");
            Console.WriteLine("║ 2.- Busqueda por autor   ║");
            Console.WriteLine("║ 5.- Salir                ║");
            Console.WriteLine("╚══════════════════════════╝");
        }
    }
}
