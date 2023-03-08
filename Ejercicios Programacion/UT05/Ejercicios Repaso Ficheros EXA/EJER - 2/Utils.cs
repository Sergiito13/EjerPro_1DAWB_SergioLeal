using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    class Utils
    {
        public static string PedirNombreArchivo()
        {
            // Declaramos las variables
            bool salir = false;
            string nombreFichero = "";

            do
            {
                Console.WriteLine("Dime un nombre para el fichero");
                nombreFichero = "..\\..\\..\\" + Console.ReadLine();

                if (nombreFichero.Length > 0)
                {
                    if (File.Exists(nombreFichero))
                    {
                        salir = true;
                    }
                    else
                    {
                        Console.WriteLine("Error! El fichero no existe");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Error ! La cadena no puede estar vacia");
                }
            } while (!salir);
            return nombreFichero;
        }

        public static void LeerFichero(string nombreFicheroLectura)
        {
            // Declaramos las variables
            StreamReader SRead = null;
            String linea = "", contenidoLinea;

            try
            {
                SRead = new StreamReader(nombreFicheroLectura);

                contenidoLinea = Console.ReadLine();
                while (!SRead.EndOfStream)
                {
                    linea = Console.ReadLine();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
