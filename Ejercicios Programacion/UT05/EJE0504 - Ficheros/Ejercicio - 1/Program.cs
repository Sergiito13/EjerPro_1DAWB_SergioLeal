using Ejercicio___1;
namespace Ejercicio1Ficheros
{
    class Program
    {
        static void Main(String[] agrs)
        {
            // Declaramos las variables

            if (Fichero.CrearFichero())
            {
                Fichero.LeerFicheroExistente();
            }
        }

    }
}
