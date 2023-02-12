using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Ejercicio5
{
    class Funciones
    {
        public static string PedirNombreFicheroOrigen() // ESTA FUNCION PEDIRA UN NOMBRE PARA EL FICHERO1
        {
            // Declaramos las variables
            const string DIGITOSNOVALIDOSFICHEROS = "/:*?<>|";
            string NombreFicheroOrigen = "";
            bool salir = false, InvalidDigito = false;
            

            do
            {
                Console.WriteLine("Dime el nombre de fichero origen");
                NombreFicheroOrigen = Console.ReadLine();
                NombreFicheroOrigen = NombreFicheroOrigen.Trim();

                if (NombreFicheroOrigen.Length > 0)
                {
                    if (NombreFicheroOrigen.Contains(".txt"))
                    {
                        InvalidDigito = false;
                        foreach (char Digito in DIGITOSNOVALIDOSFICHEROS)
                        {
                            if (NombreFicheroOrigen.Contains(Digito))
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
                            salir = true;
                            
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

            return NombreFicheroOrigen;
        }

        public static string PedirNombreFicheroDestino() // ESTA FUNCION PEDIRA UN NOMBRE PARA EL FICHERO2
        {
            // Declaramos las variables
            // Declaramos las variables
            const string DIGITOSNOVALIDOSFICHEROS = "/:*?<>|";
            string NombreFicheroDestino = "";
            bool salir = false, InvalidDigito = false;


            do
            {
                Console.WriteLine("Dime el nombre de fichero destino");
                NombreFicheroDestino = Console.ReadLine();
                NombreFicheroDestino = NombreFicheroDestino.Trim();

                if (NombreFicheroDestino.Length > 0)
                {
                    if (NombreFicheroDestino.Contains(".txt"))
                    {
                        InvalidDigito = false;
                        foreach (char Digito in DIGITOSNOVALIDOSFICHEROS)
                        {
                            if (NombreFicheroDestino.Contains(Digito))
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
                            salir = true;

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

            return NombreFicheroDestino;
        } 

        public static string AbrirCopiarFicheroOrigen(string NombreFicheroOrigen) // ESTA FUNCION COPIARA EL FICHERO ORIGEN
        {
            // Declaramos las variables
            StreamReader sread = null;
            string Linea = "";

            try
            {
                sread = new StreamReader(NombreFicheroOrigen);
                Linea = sread.ReadToEnd();
            }
            catch (ArgumentException Ae)
            {
                Console.WriteLine(Ae.Message);
            }
            catch (FileNotFoundException FNFE)
            {
                Console.WriteLine(FNFE.Message);
            }
            catch (OutOfMemoryException outOfmemoryE)
            {
                Console.WriteLine(outOfmemoryE.Message);
            }
            catch (IOException IOE)
            {
                Console.WriteLine(IOE.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            sread.Close();
            Console.Clear();
            return Linea;
        }

        public static void CrearFicheroDestino(string NombreFicheroDestino) // ESTA FUNCION COMPROBARA SI EXISTE EL FICHERO DESTINO Y SI NO LO CREARA
        {
            // Declaramos las variables 
            StreamWriter swrite = null;

            if (!File.Exists(NombreFicheroDestino))
            {
                try
                {
                    swrite = File.CreateText(NombreFicheroDestino);
                    Console.WriteLine("El fichero se ha creado correctamente");
                }
                catch (UnauthorizedAccessException AccessE)
                {
                    Console.WriteLine(AccessE.Message);
                }
                catch (PathTooLongException LoongE)
                {
                    Console.WriteLine(LoongE.Message);
                }
                catch (Exception E)
                {
                    Console.WriteLine(E.Message);  
                }
            }
            else
            {
                Console.WriteLine("El fichero ya existe");
            }
        }
    
        public static void CopiarContenidoFicheroDestino(string NombreFicheroDestino, string ContenidoFicheroOrigen) // ESTA FUNCION COPIARA EL CONTENIDO EN EL FICHERO DESTINO
        {
            // Declaramos las variables
            StreamWriter swrite = null;

            try
            {
                swrite = new StreamWriter(NombreFicheroDestino);
                swrite.WriteLine(ContenidoFicheroOrigen);
            }
            catch (ArgumentException Ae)
            {
                Console.WriteLine(Ae.Message);
            }
            catch (FileNotFoundException FNFE)
            {
                Console.WriteLine(FNFE.Message);
            }
            catch (OutOfMemoryException outOfmemoryE)
            {
                Console.WriteLine(outOfmemoryE.Message);
            }
            catch (IOException IOE)
            {
                Console.WriteLine(IOE.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }
    
        public static void MostrarContenidoFicheroDestino(string NombreFicheroDestino) // ESTA FUNCION MOSTRARA EL CONTENIDO DEL FICHERO DESTINO
        {
            // Declaramos las variables
            StreamReader sread = null;

            try
            {
                sread = new StreamReader(NombreFicheroDestino);

                Console.Clear();
                Console.WriteLine($"El contenido del fichero {NombreFicheroDestino}  :");
                while (!sread.EndOfStream)
                {
                    Console.WriteLine(sread.ReadLine());
                }
            }
            catch (ArgumentException Ae)
            {
                Console.WriteLine(Ae.Message);
            }
            catch (FileNotFoundException FNFE)
            {
                Console.WriteLine(FNFE.Message);
            }
            catch (OutOfMemoryException outOfmemoryE)
            {
                Console.WriteLine(outOfmemoryE.Message);
            }
            catch (IOException IOE)
            {
                Console.WriteLine(IOE.Message);
            }
            catch (ObjectDisposedException ODE)
            {
                Console.WriteLine(ODE.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            sread.Close();

        }
    }
}
