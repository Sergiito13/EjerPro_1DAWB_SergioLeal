using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{
    class Funciones
    {

        
        public static int SolicitarNumeroCasas() // ESTA FUNCION LO QUE HARA ES SOLICITAR EL NUMERO DE CASAS QUE QUEREMOS ALMACENAR (TIENEN QUE ESTAR ENTRE 10 Y 30)
        {
            // Declaramos las varables
            bool Salir = false;
            int NumeroUsuario = 0;
           
            do
            {
                Console.WriteLine("Dime el número de casas que quieres almacenar (Tiene que ser entre 10 y 30)");
                while(!int.TryParse(Console.ReadLine(), out NumeroUsuario)) // Cuemprueba que el dato introducido es de tipo int 
                {
                    Console.WriteLine("ERROR ! El tipo de dato tiene que ser de tipo entero");
                }

                if ((NumeroUsuario >= 10) && (NumeroUsuario <= 30)) // Si el número esta entre 10 y 30 saldra del bucle si no muestra error y te lo vuelve a pedir.
                {

                    Console.WriteLine($"Haz elegido introducir {NumeroUsuario}");
                    Salir = true;
                }
                else
                {
                    Console.WriteLine("ERROR ! El número tiene que estar entre 10 y 30");
                }

            } while (!Salir);

            return NumeroUsuario; // Devolvemos el dato solicitado
        }

        public static string[] SolicitarNombreCasas(int numeroCasas, string[] NombreCasa, int ContadorNumeroCasas) // ESTA FUNCIUON LO QUE HARA ES PEDIR LOS NOMBRE DE LA CASA Y COMPROBAR QUE NO HAY OTRO NOMBRE IGUAL
        {
            // Declaramos las variables
            string[] NombreCasas = new string[numeroCasas];
            bool Salir = false;
            string CadenaUsu = "";

            do
            {
                Console.WriteLine("\n-----------------------------------------------------");
                Console.WriteLine($"Dime el nombre de la casa {ContadorNumeroCasas+1}");
                CadenaUsu = Console.ReadLine();
                CadenaUsu = CadenaUsu.Trim();

                if (CadenaUsu.Length > 0) // Comprobamos que la cadena no este vacia
                {

                    if (!NombreCasa.Contains(CadenaUsu)) // Comprobamos que la cadena no este repetida en la string
                    {
                        NombreCasa[ContadorNumeroCasas] = CadenaUsu;
                        Console.WriteLine($"[Se ha añadido la casa {ContadorNumeroCasas+1} con el nombre {CadenaUsu}]");
                        Salir= true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR! El nombre de la cadena ya existe");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR ! La cadena no puede estar vacia ");
                }


            } while (!Salir);

            return NombreCasa;
        }

        public static double[] SolicitarCostoCasas(int numeroCasas, double[] CostoCasa, int ContadorNumeroCasas) // ESTA FUNCION LO QUE HARA ES PEDIR EL PRECIO DE LAS CASAS 
        {
            // Declaramos las variables
            string[] NombreCasas = new string[numeroCasas];
            bool Salir = false;
            double NumeroUsu = 0;

            do
            {
                Console.WriteLine($"Dime el precio de la casa {ContadorNumeroCasas + 1}");
                while (!double.TryParse(Console.ReadLine(), out NumeroUsu))
                {
                    Console.WriteLine("ERROR ! El tipo de dato tiene que ser numérico");
                }

                if (NumeroUsu > 0)
                {
                    NumeroUsu = Math.Round(NumeroUsu, 2);
                    CostoCasa[ContadorNumeroCasas] = NumeroUsu;
                    Console.WriteLine($"[Se ha introducido el precio de la casa {ContadorNumeroCasas + 1} con el precio {NumeroUsu} Euros]");
                    Salir= true;
                }
                else
                {
                    Console.WriteLine("ERROR ! El precio de la casa no puede ser negativo , ni 0");
                }

                


            } while (!Salir);

            return CostoCasa;

        }
    
        public static double SolicitarLimiteInferiorCosto() // ESTA FUNCION PEDIRA UN LIMITE INFERIOR
        {
            // Declaramos las variables 
            bool Salir = false;
            Double NumeroUsu = 0;


            do
            {
                Console.WriteLine("Dime un limite inferior para generar el listado de casas");
                while (!double.TryParse(Console.ReadLine(), out NumeroUsu))
                {
                    Console.WriteLine("ERROR ! El tipo de dato tiene que ser numérico");
                }

                if (NumeroUsu > 0)
                {
                    NumeroUsu = Math.Round(NumeroUsu, 2);
                    Console.WriteLine($"El limite inferior sera de: {NumeroUsu} Euros");
                    Salir = true;
                }
                else
                {
                    Console.WriteLine("ERROR ! El limite inferiro no puede ser menor a 0");
                }

            } while (!Salir);
            Console.WriteLine("-------------------------------------------------------");

            return NumeroUsu;
        }

        public static double SolicitarLimiteSuperiorCosto(double LimiteInferior)// ESTA FUNCION SOLICITARA EL LIMITE SUPERIOR, LE MANDAMOS EL LIMITE INFERIOR PORQUE EL LIMITE SUPERIOR NO PUEDE SER MENOR AL LIMITE INFERIOR
        {
            // Declaramos las variables 
            bool Salir = false;
            Double NumeroUsu = 0;


            do
            {
                Console.WriteLine("Dime un limite superior para generar el listado de casas");
                while (!double.TryParse(Console.ReadLine(), out NumeroUsu))
                {
                    Console.WriteLine("ERROR ! El tipo de dato tiene que ser numérico");
                }

                if (NumeroUsu > LimiteInferior)
                {
                    NumeroUsu = Math.Round(NumeroUsu, 2);
                    Console.WriteLine($"El limite superior sera de: {NumeroUsu} Euros");
                    Salir = true;
                }
                else
                {
                    Console.WriteLine("ERROR ! El limite superior no puede ser menor a el limite inferior");
                }

            } while (!Salir);
            Console.WriteLine("-------------------------------------------------------");

            return NumeroUsu;


        }
        
        public static double[] SacarListadoLimites(double LimiteInferior, double LimiteSuperior, double[] Costos)// ESTA FUNCION GUARDA EN UN VECTOR EL PRECIO DE LAS CASAS QUE ESTAN ENTRE MEDIO DE LOS LIMITES
        {
            // Declaramos las variables
            double[] EntreLimites = new double[0];
            int Contador = 0;

            for (int i = 0; i < Costos.Length; i++)
            {
                if ((Costos[i] >= LimiteInferior) && (Costos[i] <= LimiteSuperior))
                {
                    Array.Resize(ref EntreLimites, EntreLimites.Length+1);
                    EntreLimites[Contador] = Costos[i];
                    Contador++;
                }
            }

            return EntreLimites;
        }
    
        public static string SolicitarNombreCasaExistente(string[] NombreCasas) // ESTA FUNCION Solicitara un nombre de casa existente
        {
            // Declaramos las variables
            bool Salir = false;
            int Contador= 0;
            string NombreCasaUsu = "";

            Console.WriteLine("Los nombre de casas almacenados son:");
            Console.WriteLine(" [ ");
            for (int i = 0; i < NombreCasas.Length; i++)
            {
                Console.Write($" {NombreCasas[i]} ");
            }
            Console.WriteLine(" ] ");

            do
            {
                Console.WriteLine("\nDime el nombre de una casa existente y se te mostrara todas las que tengan un precio inferior");
                NombreCasaUsu = Console.ReadLine();
                NombreCasaUsu = NombreCasaUsu.Trim();

                if (NombreCasaUsu.Length > 0)
                {

                    if (NombreCasas.Contains(NombreCasaUsu))
                    {
                        Console.WriteLine($"La casa seleccionada es: {NombreCasaUsu}");
                        Salir = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR! El nombre introducido no se encuentra");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR ! No se permite que este vacia");
                }


            }while(!Salir);

            return NombreCasaUsu;
        }
    
        public static double SacarListadoNombreCasa(string[] NombreCasas, double[] PrecioCasa, string NombreCasaSeleccionada) // ESTA FUNCION SACA EL PRECIO DEL NOMBRE DE LA CASA QUE ELIGIO EL USUARIO
        {
            // Declaramos las variables 
            double Precio = 0;

            for (int i = 0; i < NombreCasas.Length; i++)
            {
                if (NombreCasas[i] == NombreCasaSeleccionada)
                {
                    Precio = PrecioCasa[i];
                }
            }

            return Precio;
        } 

        public static void MostrarCasaLimiteInferiosSuperior(Double[] Costos, double[] CostosEntreLimites, string[] Casas) // ESTA FUNCION MUESTRA LAS CASAS Y EL PRECIO QUE ESTAN ENTRE EL LIMITE INFERIOR Y SUPERIOR
        {
            // Declaramos las variables
            int ContadorEntreLimites = 0;

            Console.WriteLine("\nLas casas que se encuentran entre los limites son:");
            for (int j = 0; j < Costos.Length; j++) // Este bucle recorrera el vector de costos (Donde se almacena todos los precios de las casas )
            {
                ContadorEntreLimites = 0;
                while (ContadorEntreLimites < CostosEntreLimites.Length) // Este bucle recorrera el vector CostosEntrelimites (Donde se almacena los precios que estan en los limites)
                {
                    if (Costos[j] == CostosEntreLimites[ContadorEntreLimites])
                    {
                        Console.WriteLine($" {Casas[j]} ");
                        Console.WriteLine($" {Costos[j]} ");
                        CostosEntreLimites[ContadorEntreLimites] = -1;
                        ContadorEntreLimites = CostosEntreLimites.Length;
                    }
                    else
                    {
                        ContadorEntreLimites++;
                    }
                }
            }
        }
        
        public static void MostrarCasaInferioresPrecio(string[] NombreCasas, double[] PrecioCasa, double PrecioCasaSeleccionada)// ESTA FUNCION MUESTRA LAS CASAS MENORES A LA CASA ELEGIDA POR EL USUARIO 
        {
            // Declaramos las variables

            Console.WriteLine("\nLa casas inferiores a la seleccionada son: ");
            for (int i = 0; i < PrecioCasa.Length; i++)
            {
                if (PrecioCasa[i] < PrecioCasaSeleccionada)
                {
                    Console.WriteLine($" {NombreCasas[i]} ");
                    Console.WriteLine($" {PrecioCasa[i]} ");
                }
            }
        } 
    

    }
}
