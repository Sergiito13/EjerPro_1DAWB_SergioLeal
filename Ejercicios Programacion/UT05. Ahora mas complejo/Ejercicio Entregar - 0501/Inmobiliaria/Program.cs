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
            double[] Costos ;
            double LimiteInferior = 0, LimiteSuperior = 0;
            int numeroCasas = 0, ContadorVeces = 0;
            

            numeroCasas = Funciones.SolicitarNumeroCasas(); // Llamamos a la funcion SolicitarNumeroCasas que pedira un numero
            
            Casas= new string[numeroCasas];
            Costos= new double[numeroCasas];

            do
            {
                Casas = Funciones.SolicitarNombreCasas(numeroCasas, Casas, ContadorVeces);// Llamamos a la función para pedir el nombre de las casas

                Costos = Funciones.SolicitarCostoCasas(numeroCasas,Costos, ContadorVeces); // Llamamos a la funcion para pedir el precio de las casas

                ContadorVeces++;

            }while(ContadorVeces < numeroCasas); // Llamara a la funcion las veces solicitadas en la funcion SolicitarNumeroCasas

            Console.Clear();

            LimiteInferior = Funciones.SolicitarLimiteInferiorCosto(); // Llamamos a la funcion para pedir el limite inferior 

            LimiteSuperior = Funciones.SolicitarLimiteSuperior(LimiteInferior); // Llamamos a la funcion para pedir el limite superior pasandole el limite inferior para calcular que el limite superior no sea menor al inferior



        }
    }
}