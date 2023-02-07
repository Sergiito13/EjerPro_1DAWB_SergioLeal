using System.Globalization;

namespace Ejercicio2Fichero
{
    class Fichero
    {
        public const string NOMBREFICHERO = "Ejercicio2.txt";
        public static void CrearFichero() // ESTA FUNCION CREARA EL ARCHIVO 
        {
            // Declramos las variables
            string nombrefichero = "", EleccionUsuario = "";
            bool Salir = false;
            StreamWriter Write = null;


            Console.WriteLine("\n");

            if (!File.Exists(NOMBREFICHERO))
            {
                try // Se ha creado correctamente
                {
                    Write = File.CreateText(NOMBREFICHERO);
                    Write.Close();
                    Console.WriteLine("El archivo no estaba escrito y se ha creado correctamente");
                }
                catch (Exception ex) // Ha dado error
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("El fichero ya existe ¿Quieres sobreescribirlo? [Si o No]");
                    EleccionUsuario = Console.ReadLine();

                    if ((EleccionUsuario == "si") || (EleccionUsuario == "Si") || (EleccionUsuario == "SI") || (EleccionUsuario == "sI"))
                    {
                        try // Se ha sobre escrito correctamente
                        {
                            Write = File.CreateText(NOMBREFICHERO);
                            Write.Close();
                            Console.WriteLine("Se ha sobreescrito el fichero correctamente");
                            Salir = true;
                        }
                        catch (Exception ex) // Ha dado error
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        if ((EleccionUsuario == "no") || (EleccionUsuario == "No") || (EleccionUsuario == "No") || (EleccionUsuario == "nO"))
                        {
                            Console.WriteLine("Ha elegido no sobrescribir el archivo");
                            Salir = true;
                        }
                        else
                        {
                            Console.WriteLine("No haz seleccionado una opcion valida. Intentelo de nuevo [Si o No]");
                        }
  
                    }
                } while (!Salir);

            }
        }

        public static void IntroducirValoresFichero() // ESTA FUNCION AÑADIRA VALORES AL FICHERO DE TEXTO
        {
            // Declaramos las variables
            StreamWriter Write = null;
            int NumeroUsuario = 0;

            Console.Clear();
            try // Se ha creado correctamente
            {
                Write = new StreamWriter(NOMBREFICHERO, true);
                Console.WriteLine("Introduzca el valor que quiere introducir");
                Console.WriteLine("-----------------------------------------");

                while (!int.TryParse(Console.ReadLine(), out NumeroUsuario))
                {
                    Console.WriteLine("Error! El tipo de dato tiene que ser entero");
                }
                Write.WriteLine(NumeroUsuario);
                Write.Close();
                Console.Clear();
                Console.WriteLine("\n\nNumero introducido correctamente");
            }
            catch (Exception ex) // Ha dado error
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static int[] LeerValoresdelFichero() // ESTA FUNCION LEERA LOS VALORES DEL FICHEROY LOS ALMACENARA EN UN ARRAY
        {
            // Declaramos las variables
            int[] ValoresFichero = new int[0];
            StreamReader Read = null;
            int Contador = 0;

            try
            {
                Read = new StreamReader(NOMBREFICHERO);
                while (!Read.EndOfStream)
                {
                    Array.Resize(ref ValoresFichero, ValoresFichero.Length + 1);
                    ValoresFichero[Contador] = Convert.ToInt32(Read.ReadLine());
                    Contador++;
                }
                Read.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return ValoresFichero;
        }
        
        public static int ValorMaximoFichero() // ESTA FUNCION LEERA EL FICHERO Y SACARA EL VALOR  MAXIMO DEL FICHERO
        {
            // Declaramos las variables
            int ValorMaximoFichero = 0;

            int[] NumerosFichero = LeerValoresdelFichero();

            ValorMaximoFichero = NumerosFichero[0];

            for (int i = 0; i < NumerosFichero.Length; i++)
            {
                if (ValorMaximoFichero < NumerosFichero[i])
                {
                    ValorMaximoFichero = NumerosFichero[i];
                }
            }
            Console.WriteLine($"El valor maximo es {ValorMaximoFichero}");
            return ValorMaximoFichero;
            
        }

        public static int ValorMinimoFichero() // ESTA FUNCION LEERA EL FICHERO Y SACARA EL VALOR MINIMO DEL FICHERO
        {
            // Declaramos las variables
            int valorminimo = ValorMaximoFichero();
            int[] NumerosFichero = LeerValoresdelFichero();

            for (int i = 0; i < NumerosFichero.Length; i++)
            {
                if (NumerosFichero[i] < valorminimo)
                {
                    valorminimo = NumerosFichero[i];
                }
            }
            Console.WriteLine($"El valor minimo es {valorminimo}");
            return valorminimo;
        }

        public static decimal CalcularMediaFichero() // ESTA FUNCION LEERA EL FICHERO Y SACARA LA MEDIA 
        {
            // Declaramos las variables
            decimal Media = 0;
            int[] NumerosFichero = LeerValoresdelFichero();

            for (int i = 0; i < NumerosFichero.Length; i++)
            {
                Media += NumerosFichero[i]; 
            }
            Media = Media/NumerosFichero.Length;

            Console.WriteLine($"La media es de {Media}");
            return Media;
        }


    }
}
