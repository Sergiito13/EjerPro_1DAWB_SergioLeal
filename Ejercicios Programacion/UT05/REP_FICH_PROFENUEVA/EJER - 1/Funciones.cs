using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    internal class Funciones
    {
        public static bool ExisteFicheroNombre(string rutaFicheroNombre)
        {
            // Declaramos las variables
            bool errores = false;

            if (!File.Exists(rutaFicheroNombre))
            {
                errores = true;
            }
            return errores;
        }

        public static List<string> SacarNombreFichero(string rutaFicheroNombre)
        {
            // Declaramos las variables
            List<string> nombresFicheros = new List<string>();
            StreamReader SRead;

            try
            {
                SRead = new StreamReader(rutaFicheroNombre);

                while (!SRead.EndOfStream)
                {
                    string linea = SRead.ReadLine();

                    nombresFicheros.Add(linea);
                }

                SRead.Close();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Ha ocurrido un error al tratar el fichero de los datos");
            }
            return nombresFicheros;
        }

        public static List<string> OrdenarAlphabeticamente(List<string> nombres)
        {
            // Declaramos las variables
            StreamWriter SW;
            const string FICHERO_ORDENADO_ALFABETICAMENTE = "..\\..\\..\\Fichero_ordenado_alfabeticamente.txt";

            List<string> nombresOrdenados = nombres;
            nombresOrdenados.Sort();

            try
            {
                SW = new StreamWriter(FICHERO_ORDENADO_ALFABETICAMENTE);

                foreach (string nombreor in nombresOrdenados)
                {
                    SW.WriteLine(nombreor);
                }

                SW.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error con el archivo: {FICHERO_ORDENADO_ALFABETICAMENTE}");
                throw;
            }

            return nombresOrdenados;
        }

        public static void OrdenarAlContrarioAlphabeticamente(List<string> nombresOrdenados)
        {
            // Declaramos las variables
            StreamWriter SW2;
            const string FICHERO_ORDENADO_ALFABETICAMENTEALREVES = "..\\..\\..\\Fichero_ordenado_alreves_alfabeticamente.txt";

            try
            {
                SW2 = new StreamWriter(FICHERO_ORDENADO_ALFABETICAMENTEALREVES);

                for (int i = nombresOrdenados.Count-1; i >= 0; i--)
                {
                    SW2.WriteLine(nombresOrdenados[i]);
                }
                SW2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error con el archivo: {FICHERO_ORDENADO_ALFABETICAMENTEALREVES}");
            }
}
    }
}
