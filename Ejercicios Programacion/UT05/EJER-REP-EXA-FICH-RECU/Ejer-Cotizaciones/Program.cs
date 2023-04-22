using System;
namespace ejercotizaciones
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // 1.- Construir una función reciba que el fichero de cotizaciones y devuelva una  lista con los datos del fichero por columnas.
            // 2.- Construir una función que reciba la lista devuelto por la función anterior y cree un fichero en formato csv con el mínimo, el máximo y la media de dada columna.
            // Declaramos las variables
            const string RUTA_FICHERO_SALIDA = "..\\..\\..\\FicheroSalida.csv";
            bool FicheroExiste = Funciones.ComprobarSiExisteFichero();

            if (FicheroExiste)
            {
                List<string> lista = Funciones.SacarLosDatosDelFichero();
                for (int i = 0; i < lista.Count; i+=6)
                {
                    Console.WriteLine($"{lista[i]} | {lista[i+1]} | {lista[i+2]} | {lista[i+3]} | {lista[i+4]} | {lista[i+5]}");
                }

                Funciones.CrearFicheroSalida(RUTA_FICHERO_SALIDA);
                Funciones.EscribirFicheroSalida(lista, RUTA_FICHERO_SALIDA);
            }
            else
            {
                Console.WriteLine($"Error ! El fichero {Funciones.RUTA_DEL_FICHERO_COTIZACIONES} no se ha encontrado");
            }
        }
    }
}
