using System.Diagnostics;
using System.Numerics;

namespace Ejercicio___1
{
    class Fichero
    {
        public const string NOMBREFICHERO = "FicheroFinal.txt";

        public static bool CrearFichero()
        {
            // Declaramos las variables
            bool Salida = true;
            StreamWriter SWrite = null;

            try // Si no existe lo inentamos crear
            {
                SWrite = File.CreateText(NOMBREFICHERO);
                SWrite.Close();
                Console.WriteLine("Fichero Creado sin texto");
            }
            catch (Exception ex) // Si ha dado algun error
            {
                Console.WriteLine(ex.Message);
                Salida = false;
            }

            return Salida;
        }

        public static string[] LeerFicheroExistente()
        {
            // Declaramos las variables
            string[] VectorSeparado = new string[0];
            StreamReader SRead = null;
            string DatoIntroducido = "";

            try
            {
                SRead = new StreamReader("FicheroInicial.txt");
                while (!SRead.EndOfStream)
                {
                    DatoIntroducido += ';' + SRead.ReadLine();
                }
                VectorSeparado = DatoIntroducido.Split(';');
                SRead.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (string dato in VectorSeparado)
            {
                Console.WriteLine($" {dato} ");
            }
            return VectorSeparado;
        }
}
}
