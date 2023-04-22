using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercotizaciones
{
    class Funciones
    {
        public const string RUTA_DEL_FICHERO_COTIZACIONES = "..\\..\\..\\cotizacion.csv";
        public static bool ComprobarSiExisteFichero()
        {
            // Declarabos las variables
            bool exist = true;

            if (!File.Exists(RUTA_DEL_FICHERO_COTIZACIONES))
            {
                exist = false;
            }
            return exist;
        }

        public static List<string> SacarLosDatosDelFichero()
        {
            // Declaramos las variables
            List<string> ListaDatos = new List<string>();
            StreamReader SR;

            try
            {
                SR = new StreamReader(RUTA_DEL_FICHERO_COTIZACIONES);
                SR.ReadLine();
                
                while (!SR.EndOfStream)
                {
                    string Linea = SR.ReadLine();
                    string[] LineaSeparada = Linea.Split(';');

                    ListaDatos.Add(LineaSeparada[0]);
                    ListaDatos.Add(LineaSeparada[1]);
                    ListaDatos.Add(LineaSeparada[2]);
                    ListaDatos.Add(LineaSeparada[3]);
                    ListaDatos.Add(LineaSeparada[4]);
                    ListaDatos.Add(LineaSeparada[5]);

                }
                SR.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error con algun dato del fichero");
            }
            return ListaDatos;
        }

        public static void CrearFicheroSalida(string rutaFichero)
        {
            // Declaramos las variables
            StreamWriter SW2;

            SW2 = new StreamWriter(rutaFichero);
            if (!File.Exists(rutaFichero))
            {
                SW2 = File.CreateText(rutaFichero);
                
            }

            SW2.Close();
        }

        public static void  EscribirFicheroSalida(List<string> lista, string rutaFichero)
        {
            // Declaramos las variables
            StreamWriter SW;
            decimal Media = 0;

            try
            {
                SW = new StreamWriter(rutaFichero);

                for (int i = 0; i < lista.Count; i += 6)
                {
                    Media = 0;
                    Media = (Convert.ToDecimal(lista[i + 2]) + Convert.ToDecimal(lista[i + 3]))/2;

                    SW.WriteLine($"{lista[i]},{lista[i + 3]},{lista[i+2]}, {Convert.ToString(Media)}");
                    
                }
                SW.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Error , a abrir el archivo");
            }
            
        }
    }
}
