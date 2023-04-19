using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercotizaciones
{
    class Funciones
    {
        public const string RUTA_DEL_FICHERO_COTIZACIONES = "..\\..\\..\\cotizaciones.csv";
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error con algun dato del fichero");
            }

        }
    }
}
