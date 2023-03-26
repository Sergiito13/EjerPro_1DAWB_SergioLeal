using System;
namespace ejer1
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // Declaramos las variables
            const string RUTA_FICHERO_NOMBRES = "..\\..\\..\\Nombres.csv";

            bool errores = Funciones.ExisteFicheroNombre(RUTA_FICHERO_NOMBRES);

            if (!errores)
            {
                List<string> nombres = Funciones.SacarNombreFichero(RUTA_FICHERO_NOMBRES);
                List<string> nombreOrdenado = Funciones.OrdenarAlphabeticamente(nombres);
                Funciones.OrdenarAlContrarioAlphabeticamente(nombreOrdenado);
            }
            else
            {
                Console.WriteLine($"Ha ocurrido un error al intenter leer el fichero: {RUTA_FICHERO_NOMBRES} ");
            }



        }
    }
}
