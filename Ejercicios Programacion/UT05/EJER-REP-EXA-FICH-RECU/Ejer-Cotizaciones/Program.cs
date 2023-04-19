using System;
namespace ejercotizaciones
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // 1.- Construir una función reciba que el fichero de cotizaciones y devuelva una  lista con los datos del fichero por columnas.
            // 2.- Construir una función que reciba la lista devuelto por la función anterior y cree un fichero en formato csv con el mínimo, el máximo y la media de dada columna.

            bool FicheroExiste = Funciones.ComprobarSiExisteFichero();

            if (FicheroExiste)
            {

            }
            else
            {
                Console.WriteLine($"Error ! El fichero {Funciones.RUTA_DEL_FICHERO_COTIZACIONES} no se ha encontrado");
            }
        }
    }
}
