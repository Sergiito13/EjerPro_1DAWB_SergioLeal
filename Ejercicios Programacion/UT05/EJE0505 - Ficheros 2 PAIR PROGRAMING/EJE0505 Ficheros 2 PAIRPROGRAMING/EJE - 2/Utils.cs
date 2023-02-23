using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE2FICHEROS
{
    class Funciones
    {
        public static string PedirNombreFichero() // ESTA FUNCION PEDIRA UN NOMBRE DE FICHERO
        {
            // Declramos las variables
            const string DIGITOSNOVALIDOSFICHEROS = "/:*?<>|";
            bool Salir = false, InvalidDigito;
            string rutaFichero = "";

            do
            {

                Console.WriteLine("Dime el nombre/ruta del fichero");
                rutaFichero = Console.ReadLine();

                if (rutaFichero.Length > 0)
                {
                    if (rutaFichero.Contains(".txt"))
                    {
                        InvalidDigito = false;
                        foreach (char Digito in DIGITOSNOVALIDOSFICHEROS)
                        {
                            if (rutaFichero.Contains(Digito))
                            {
                                InvalidDigito = true;
                            }
                        }

                        if (InvalidDigito)
                        {
                            Console.WriteLine("Error ! El nombre del fichero contiene algun caracter no valido");
                        }
                        else
                        {
                            Console.WriteLine("El nombre ha sido aceptado por el programa");
                            Salir = true;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Error al nombre del fichero le falta la extension .txt");
                    }
                }
                else
                {
                    Console.WriteLine("Error! el nombre del fichero no puede estar vacio");
                }

            } while (!Salir);
            return rutaFichero;

        }

        public static int PedirNumeroLineas() // ESTA FUNCION PEDIRA X NUMERO DE LINEAS
        {
            // Declaramos las variables
            int numeroLineas = 0;
            bool Salir = false;

            do
            {
                Console.WriteLine("Dime el número de lineas que quieres leer");
                while (!int.TryParse(Console.ReadLine(), out numeroLineas))
                {
                    Console.WriteLine("Error el número tiene que ser de tipo entero");
                }

                if (numeroLineas < 0)
                {
                    Salir = true;
                }
                else
                {
                    Console.WriteLine("Error el número no puede ser negativo");
                }

            } while (!Salir);
            return numeroLineas;
        } 

        public static void AbrirFicheroLeerloMostrarLineas(String nombreFich, int numeroLineas) // ESTA FUNCION LEERA EL FICHERO
        {
            // Declaramos las variables
            StreamReader SRead = null;

            try
            {
                SRead = new StreamReader(nombreFich);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
