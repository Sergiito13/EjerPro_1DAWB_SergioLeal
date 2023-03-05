using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerFicheros
{
    public struct mediaMunicipios
    {
        public string municipio;
        public int mediaMunicipio;
    }

    class Utils
    {
        public static List<mediaMunicipios> LeerDatosFichero()
        {
            // Declaramos las variables
            const string NOMBREFICHEROPRINCIPALCSV = "..\\..\\..\\edades-medias-de-la-poblacion.csv";
            string lineasFichero = "" ;
            int contadorLinea = 1, contadorPosiciones = 0;
            string[] nombreMunicipio = new string[0];
            bool error = false ;
            List<mediaMunicipios> datosMunicipio = new List<mediaMunicipios>();
            StreamReader SRead= null;

            //try
            //{
                SRead = new StreamReader(NOMBREFICHEROPRINCIPALCSV);

                while ((!SRead.EndOfStream) && (!error))
                {
                    lineasFichero = SRead.ReadLine();
                    string[] lineaContenido = lineasFichero.Split(";");

                    if (contadorLinea >= 2)
                    {
                        for (int i = 3; i < lineaContenido.Length; i++)
                        {
                        datosMunicipio.Add(new mediaMunicipios { municipio = lineaContenido[3], mediaMunicipio = int.Parse(lineaContenido[i+1]) });
                        
                        }
                        contadorLinea++;
                    }
                    else
                    {
                        contadorLinea++;
                    }
                }
                SRead.Close();

                foreach (mediaMunicipios datos in datosMunicipio)
                {
                    Console.WriteLine(datos.municipio);
                    Console.WriteLine(datos.mediaMunicipio);
                }
                Console.WriteLine("");




            //}
            //catch (Exception EX)
            //{
             //   Console.WriteLine(EX.Message);
            //}

            return datosMunicipio;
        }


    }
}
