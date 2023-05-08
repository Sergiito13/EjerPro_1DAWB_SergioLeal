namespace ejer2
{
    class Menu
    {

        public static void MostrarMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════╗");
            Console.WriteLine("║ ♦ ¡Bienvenido al menú! ♦ ║");
            Console.WriteLine("╠══════════════════════════╣");
            Console.WriteLine("╠══════════════════════════╣");
            Console.WriteLine("║ 1.- Añadir Pedido cola   ║");
            Console.WriteLine("║ 2.- Pedido Realizado     ║");
            Console.WriteLine("║ 3.- Hacer caja           ║");
            Console.WriteLine("║ 4.- Salir                ║");
            Console.WriteLine("╚══════════════════════════╝");
            Console.ResetColor();

        }

        public static int PedirNumeroOpcionMenu()
        {
            // Declaramos las variables
            int numeroUser = 0;
            bool salir = false;

            do
            {
                Console.WriteLine("Dime una opción para el menu");
                while ((!int.TryParse(Console.ReadLine(), out numeroUser) || (numeroUser < 1) || (numeroUser > 4)))
                {
                    Console.WriteLine("Error ! La opción no es valida");
                }

                salir = true;

            } while (!salir);
            return numeroUser;
        }
    }
}
