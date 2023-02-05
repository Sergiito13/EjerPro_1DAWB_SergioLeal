namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] agrs)
        {
            // Ejercicio - 3 | 
            // Declaramos las variables
            string CadenaInicial = "", valorReferencia = "", CadenaFinal = "";
            bool Control = false;
            int Contador = 0;

            do
            {
                Console.WriteLine("Dime una cadenaInicial");
                CadenaInicial = Console.ReadLine();

                if (CadenaInicial.Length > 0)
                {
                    Console.WriteLine("Dime una cadena de referencia");
                    valorReferencia = Console.ReadLine();

                    if (valorReferencia.Length > 0)
                    {
                        Control = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR ! La cadena no puede estar vacia");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR ! La cadena no puede estar vacia");
                }

            } while (!Control);

            for (int i = 0; i < CadenaInicial.Length; i++)
            {
                Contador = 0;
                while (Contador < valorReferencia.Length)
                {
                    if (valorReferencia[Contador] == CadenaInicial[i])
                    {
                        Contador = valorReferencia.Length+1;
                    }
                    else
                    {
                        Contador++;
                    }

                    if (Contador == valorReferencia.Length)
                    {
                        Contador = valorReferencia.Length+1;
                        CadenaFinal += CadenaInicial[i];
                    }

                }
            }
            
            Console.WriteLine($"CadenaInical = [ {CadenaInicial} ]");
            Console.WriteLine($"Cadena de Referencia = [ {valorReferencia} ]");
            Console.WriteLine($"Cadena Final = [ {CadenaFinal} ]");
            


        }

    }
}

