using System;
namespace Inmobiliaria
{
    class Program
    {
        static void Main(string[] agrs)
        {
            // Ejercicio Inmobiliaria 
            // Declaramos las variables
            string[] Casas;
            double[] Costos, CostosEntreLimites;
            double LimiteInferior = 0, LimiteSuperior = 0;
            int numeroCasas = 0, ContadorVeces = 0;
            

            numeroCasas = Funciones.SolicitarNumeroCasas(); // Llamamos a la funcion SolicitarNumeroCasas que pedira un numero
            
            Casas= new string[numeroCasas];
            Costos = new double[numeroCasas];

            do
            {
                Casas = Funciones.SolicitarNombreCasas(numeroCasas, Casas, ContadorVeces);// Llamamos a la función para pedir el nombre de las casas

                Costos = Funciones.SolicitarCostoCasas(numeroCasas,Costos, ContadorVeces); // Llamamos a la funcion para pedir el precio de las casas

                ContadorVeces++;

            }while(ContadorVeces < numeroCasas); // Llamara a la funcion las veces solicitadas en la funcion SolicitarNumeroCasas

            Console.Clear();

            LimiteInferior = Funciones.SolicitarLimiteInferiorCosto(); // Llamamos a la funcion para pedir el limite inferior 

            LimiteSuperior = Funciones.SolicitarLimiteSuperiorCosto(LimiteInferior); // Llamamos a la funcion para pedir el limite superior pasandole el limite inferior para calcular que el limite superior no sea menor al inferior

            Console.Clear();

            CostosEntreLimites = Funciones.SacarListadoLimites(LimiteInferior, LimiteSuperior, Costos); // Llamamos a la funcion que calculara los percios de las casas que esten entre medio de los limites

            Console.WriteLine("Las casas que se encuentran entre los limites son:");
            for (int j = 0; j < Costos.Length; j++) // Este bucle recorrera el vector de costos (Donde se almacena todos los precios de las casas )
            {
                for (int z = 0; z < CostosEntreLimites.Length; z++)
                {
                    if (Costos[j] == CostosEntreLimites[z])
                    {
                        Console.WriteLine($" {Casas[j]} ");
                        Console.WriteLine($" {Costos[j]} ");
                        CostosEntreLimites[z] = -1;
                    }
                }
            }


        }
    }
}