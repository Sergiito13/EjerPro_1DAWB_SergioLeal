using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFicheros
{
    internal class Funciones
    {
        public static List<string> getCabeceras(string ficheroEntrada)
        {
            StreamReader sr;
            List<string> cabeceras = new List<string>();

            try
            {
                sr = new StreamReader(ficheroEntrada);
                cabeceras = sr.ReadLine().Split(";").ToList();
                int cont = 2;
                bool correcto = true;

                do
                {
                    int year = 0;
                    if (!int.TryParse(cabeceras[cont].Split("_")[1], out year) || year < 2000 || year > 2023){
                        correcto = false;
                        cabeceras = new List<string>();
                        //cabeceras.Clear();
                    }
                    cont++;
                } while (cont < cabeceras.Count && correcto);

                sr.Close();
            }catch(Exception e)
            {
                Console.WriteLine("Error al leer el contenido del fichero de entrada");
            }

            return cabeceras;
        }

        public static bool municipiosCorrectos(string ficheroEntrada)
        {
            StreamReader sr;
            bool correcto = true;

            try
            {
                sr = new StreamReader(ficheroEntrada);
                sr.ReadLine();

                while (!sr.EndOfStream && correcto)
                {
                    if(sr.ReadLine().Split(";")[1].Trim() == "")
                    {
                        correcto = false;
                    }
                }
                sr.Close();

            }catch(Exception e)
            {
                Console.WriteLine("Error al leer los datos del fichero de entrda");
            }

            return correcto;
        }

        public static List<string> getContenido(string ficheroEntrada)
        {
            StreamReader sr;
            List<string> contenido = new List<string>();

            try
            {
                sr = new StreamReader(ficheroEntrada);
                sr.ReadLine();
                bool correcto = true;

                while (!sr.EndOfStream && correcto) //Recorro todas las lineas del fichero
                {
                    string fila = sr.ReadLine();
                    string[] valoresFila = fila.Split(";");
                    int cont = 2;
                    do //Recorro cada posición de una fila desde la posición 2
                    {
                        if(!int.TryParse(valoresFila[cont], out int dato) || dato < 0)
                        {
                            correcto = false;
                        }
                        cont++;
                    } while (cont < valoresFila.Length && correcto);

                    if (correcto) 
                        contenido.Add(fila);
                    else 
                        contenido = new List<string>();
                }

                sr.Close();

            }catch(Exception e)
            {
                Console.WriteLine("Error al leer los datos del fichero de entrada");
            }

            return contenido;
        }

        public static void CrearFicheroSalida(string ficheroSalida, List<string> contenidoFichero, List<string> cabeceras)
        {
            StreamWriter sw;

            try
            {
                sw = new StreamWriter(ficheroSalida);

                foreach (string fila in contenidoFichero)
                {
                    sw.WriteLine(GeneraLineaFinal(fila, cabeceras));
                }
                sw.Close();
                
            }catch(Exception e)
            {
                Console.WriteLine("Error al generar el fichero de salida");
            }
        }

        private static string GeneraLineaFinal(string fila, List<string> cabeceras)
        {
            string filaFinal = "Municipio;AñoMin;ValorMin;AñoMax;ValorMax;Media";
            string[] valoresFila = fila.Split(";");
            int maxValue, maxPos=2, minValue, minPos=2;
            decimal suma = 0.0m;

            maxValue = int.Parse(valoresFila[2]);
            minValue = int.Parse(valoresFila[2]);
            suma += int.Parse(valoresFila[2]);
            for (int i = 3; i < valoresFila.Length; i++) //Recorre las posiciones de una fila
            {
                if(int.Parse(valoresFila[i]) > maxValue)
                {
                    maxValue = int.Parse(valoresFila[i]);
                    maxPos = i;
                }
                if(int.Parse(valoresFila[i]) < minValue){
                    minValue = int.Parse(valoresFila[i]);
                    minPos = i;
                }
                suma += int.Parse(valoresFila[i]);
            }

            filaFinal = valoresFila[1] + ";" + cabeceras[minPos].Split("_")[1] + ";" + minValue + ";" + cabeceras[maxPos].Split("_")[1] + ";" + maxValue + ";" + Math.Round(suma / (valoresFila.Length - 2), 2);

            return filaFinal;
        }

        public static void SolicitarDatoAlUsuario(string ficheroFinal)
        {
            decimal minMedia = GetMinMedia(ficheroFinal);
            decimal maxMedia = GetMaxMedia(ficheroFinal);
            decimal media = 0;

            Console.WriteLine("Introduzca un valor entre {0} y {1}:", minMedia, maxMedia);

            while(!decimal.TryParse(Console.ReadLine(), out media) || media<minMedia || media > maxMedia)
            {
                Console.WriteLine("El valor introducido ha de ser numérico y entre los valores {0} y {1}", minMedia, maxMedia);
            }

            List<string> municipiosMayores = GetOverMedia(media, ficheroFinal);

            foreach(string municipiosMayor in municipiosMayores)
            {
                Console.WriteLine(municipiosMayor);
            }

            Console.WriteLine("\nAdios me voy a Japón!");
        }

        private static List<string> GetOverMedia(decimal media, string ficheroFinal)
        {
            List<string> muncipiosMayores = new List<string>();
            StreamReader sr;

            try
            {
                sr = new StreamReader(ficheroFinal);
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string[] valoresFila = sr.ReadLine().Split(";");
                    if (decimal.Parse(valoresFila[5]) >= media)
                    {
                        muncipiosMayores.Add(valoresFila[0] + "\t-->\t" + valoresFila[5]);
                    }
                }
                sr.Close();
            }catch(Exception e)
            {
                Console.WriteLine("Error al obtener los municipios mayores a la media introducida");
            }

            return muncipiosMayores;
        }

        private static decimal GetMinMedia(string ficheroFinal)
        {
            StreamReader sr;
            decimal minMedia = 0;

            try
            {
                sr = new StreamReader(ficheroFinal);
                sr.ReadLine();
                minMedia = decimal.Parse(sr.ReadLine().Split(";")[5]);
                while (!sr.EndOfStream)
                {
                    string[] valoresFila = sr.ReadLine().Split(";");
                    if (decimal.Parse(valoresFila[5]) < minMedia)
                        minMedia = decimal.Parse(valoresFila[5]);
                }
                sr.Close();
            }catch(Exception ex)
            {
                Console.WriteLine("Error calculando la media mínima.");
            }

            return minMedia;
        }
        
        private static decimal GetMaxMedia(string ficheroFinal)
        {
            StreamReader sr;
            decimal maxMedia = 0;

            try
            {
                sr = new StreamReader(ficheroFinal);
                sr.ReadLine();
                maxMedia = decimal.Parse(sr.ReadLine().Split(";")[5]);
                while (!sr.EndOfStream)
                {
                    string[] valoresFila = sr.ReadLine().Split(";");
                    if (decimal.Parse(valoresFila[5]) > maxMedia)
                        maxMedia = decimal.Parse(valoresFila[5]);
                }
                sr.Close();
            }catch(Exception ex)
            {
                Console.WriteLine("Error calculando la media mínima.");
            }

            return maxMedia;
        }
    }
}
