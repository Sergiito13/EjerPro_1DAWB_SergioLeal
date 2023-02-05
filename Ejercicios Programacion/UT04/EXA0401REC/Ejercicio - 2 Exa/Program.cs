using System;
namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] agrs)
        {
            // Ejercicio 2 |
            // Declaramos las variables
            const int NUMEROMAXIMO = 8;
            int[] VectorInicial = new int[NUMEROMAXIMO];
            int[] VectorFinal;
            int ContadorVeces = 1, NumeroUsuario = 0, valorReferencia = 0, ContadorPosicionVector = 0, tamañovectorfinal = 0, maximo = 0, ContadorVectorFinal = 0;
            bool Control = false;

            do
            {
                Console.WriteLine($"Dime el numero {ContadorVeces} del vector");
                while (!int.TryParse(Console.ReadLine(), out NumeroUsuario))
                {
                    Console.WriteLine("ERROR ! El tipo de dato no es correcto");
                }

                if ((NumeroUsuario >= 100) && (NumeroUsuario <= 999))
                {
                    VectorInicial[ContadorPosicionVector] = NumeroUsuario;
                    ContadorPosicionVector++;
                    ContadorVeces++;

                }
                else
                {
                    Console.WriteLine("ERROR ! El número tiene que ser entero de tres cifras y positivos. Intentelo de nuevo");
                }

            }while(ContadorVeces <= NUMEROMAXIMO);

            do
            {
                Console.WriteLine("Dime un número de referencia");
                while (!int.TryParse(Console.ReadLine(), out valorReferencia))
                {
                    Console.WriteLine("ERROR ! El tipo de dato no es correcto");
                }

                if ((valorReferencia >= 100) && (valorReferencia <= 999))
                {
                    Control = true;
                }
                else
                {
                    Console.WriteLine("ERROR ! El numero tiene que ser entero de 3 cifras y positivo");
                }

            } while (!Control);
            Console.Clear();



            Console.Write("VectorInical = {");
            for (int i = 0; i < VectorInicial.Length; i++)
            {
                if (VectorInicial[i] < valorReferencia)
                {
                    tamañovectorfinal++;
                }

                Console.Write($" {VectorInicial[i]} , ");
            }
            Console.Write("}");

            Console.WriteLine($"\nvalorReferencia = {valorReferencia}");

            VectorFinal = new int[tamañovectorfinal];

            for (int j = 0; j < VectorInicial.Length; j++)
            {
                if (VectorInicial[j] < valorReferencia)
                {
                    VectorFinal[ContadorVectorFinal] = VectorInicial[j];
                    ContadorVectorFinal++;
                }
            }

            maximo = VectorFinal[0];

            Console.Write("VectorFinal = {");
            for (int z = 0; z < VectorFinal.Length; z++)
            {
                if (maximo < VectorFinal[z])
                {
                    maximo = VectorFinal[z];
                }
               
                Console.Write($" {VectorFinal[z]} , ");
                
            }
            Console.Write("}");
            Console.WriteLine($"\nmaximo = {maximo}");

        }
    }
}
