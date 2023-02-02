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
                Console.WriteLine($"\nDime el nombre de la casa {ContadorNumeroCasas+1}");
                CadenaUsu = Console.ReadLine();

                if (CadenaUsu.Length > 0) // Comprobamos que la cadena no este vacia
                {

                    if (!NombreCasa.Contains(CadenaUsu)) // Comprobamos que la cadena no este repetida en la string
                    {
                        NombreCasa[ContadorNumeroCasas] = CadenaUsu;
                        Console.WriteLine($"Se ha añadido la casa {ContadorNumeroCasas+1} con el nombre {CadenaUsu}");
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
            Console.WriteLine("------------------------------------------");

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
                Console.WriteLine($"\nDime el precio de la casa {ContadorNumeroCasas + 1}");
                while (!double.TryParse(Console.ReadLine(), out NumeroUsu))
                {
                    Console.WriteLine("ERROR ! El tipo de dato tiene que ser numérico");
                }

                if (NumeroUsu > 0)
                {
                    NumeroUsu = Math.Round(NumeroUsu, 2);
                    CostoCasa[ContadorNumeroCasas] = NumeroUsu;
                    Console.WriteLine($"Se ha introducido el precio de la casa {ContadorNumeroCasas + 1} con el precio {NumeroUsu} Euros");
                    Salir= true;
                }
                else
                {
                    Console.WriteLine("ERROR ! El precio de la casa no puede ser negativo");
                }

                


            } while (!Salir);
            Console.WriteLine("------------------------------------------");

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

            return NumeroUsu;
        }

        public static double SolicitarLimiteSuperior(double LimiteInferior)// ESTA FUNCION SOLICITARA EL LIMITE SUPERIOR, LE MANDAMOS EL LIMITE INFERIOR PORQUE EL LIMITE SUPERIOR NO PUEDE SER MENOR AL LIMITE INFERIOR
        {
            // Declaramos las variables 



        }

    }
}
