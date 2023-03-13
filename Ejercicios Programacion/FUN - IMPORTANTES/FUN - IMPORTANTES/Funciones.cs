using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace func_importantes
{
    class Funciones
    {
        public const string RUTA_FICHERO = "..\\..\\..\\Prueba.txt";

        // ↓ ESTA FUNCION COMPROBARA SI EXISTE UN FICHERO, SI EXISTE NOS PREGUNTA QUE SI QUEREMOS SOBREESCRIBIRLO, SI NO EXISTE CREA EL FICHERO ↓
        public static void ExisteFichero()
        {
            // Declaramos las variables
            string eleccion = "";
            StreamWriter SW = null;
            bool salir = false;

            if (File.Exists(RUTA_FICHERO))
            {
                do
                {
                    Console.WriteLine("El archivo ya existe quieres sobreescribirlo? (S/N)");
                    eleccion = Console.ReadLine();

                    if (eleccion.Length > 0)
                    {
                        if ((eleccion == "S") || (eleccion == "s"))
                        {
                            try
                            {
                                File.Delete(RUTA_FICHERO);
                                SW = new StreamWriter(RUTA_FICHERO);
                                SW.Close();
                                Console.WriteLine("Se ha sobreescrito con exito");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                            salir = true;
                        }
                        else
                        {
                            if ((eleccion == "N") || (eleccion == "n"))
                            {
                                salir = true;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error! Se esperaba una respuesta (S/N)");
                    }
                } while (!salir);



            }
            else
            {
                SW = new StreamWriter(RUTA_FICHERO);
                SW.Close();
            }

        }

        // ↓ ESTA FUNCION SOLICITA UNA CADENA Y COMPRUEBA QUE NO ESTE VACIA ↓
        public static string PedirCadena()
        {
            // Declaramos las variables
            bool salir = false;
            string cadenaUsu = "";

            do
            {
                Console.WriteLine("Dime una cadena");
                cadenaUsu = Console.ReadLine();

                if (cadenaUsu.Length > 0)
                {
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Error ! La cadena no puede estar vacia");
                }
            } while (!salir);
            return cadenaUsu;
        }

        // ↓ ESTA FUNCION SOLICITA UN NUMERO Y COMPRUEBA QUE SEA POSITIVO ↓
        public static int PedirEntero()
        {
            // Declaramos las variables
            bool salir = false;
            int numeroUsu = 0;

            do
            {
                Console.WriteLine("Dime una cadena");
                while (!int.TryParse(Console.ReadLine(), out numeroUsu))
                {
                    Console.WriteLine("Error! El dato tiene que ser de tipo entero");
                }

                if ((numeroUsu >= 0))
                {
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Error ! El número no puede ser negativo");
                }
            } while (!salir);

            return numeroUsu;
        }

        // ↓ ESTA FUNCION SOLICITA UN NOMBRE DE FICHERO Y COMPRUEBA QUE NO TENGA CARACTERES INVALIDOS Y QUE CONTIENE LA EXTENSION .TXT ↓
        public static string PedirNombreFichero() 
        {
            // Declaramos las variables
            string nombreFichero = "";
            bool salir = false;

            do
            {
                Console.WriteLine("Dime el nombre de fichero origen");
                nombreFichero = Console.ReadLine();
                nombreFichero = nombreFichero.Trim();

                if (nombreFichero.Length > 0)
                {
                    if (nombreFichero.EndsWith(".txt"))
                    {
                        if (!nombreFichero.Intersect(Path.GetInvalidFileNameChars()).Any())
                        {
                            Console.WriteLine("El nombre ha sido aceptado");
                            salir=true;
                        }
                        else
                        {
                            Console.WriteLine("Error ! El nombre contiene digitos no permitidos para un nombre de fichero");
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
            } while (!salir);
            return nombreFichero;
        }


    }
}
