namespace Ejercicio2Ficheros
{
    class ProgramPrincipal
    {
        public static void Main(string[] agrs)
        {
            // Ejercicio - 2 
            // Declaramos las variables
            int opcion = 0;
            bool salir = false;

            while (!salir)
            {
                Utils.MostrarMenu();
                opcion = Utils.PedirNumeroMenu();
                salir = Utils.Menu(opcion);

            }


        }
    }
}
