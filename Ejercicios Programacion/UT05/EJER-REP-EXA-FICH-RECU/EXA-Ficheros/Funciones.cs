using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerexam
{
    class Funciones
    {
        public static bool FicheroExiste(string rutaFichero)
        {
            // Declaramos las variables
            bool existe = true;

            if (!File.Exists(rutaFichero))
            {
                existe = false;
            }

            return existe;
        }

        public static List<string> ComprobarCabeceras(string rutaFichero)
        {
            // Declaramos las variables
            List<string> cabeceras = new List<string>();
            StreamReader SR;

            try
            {
                SR = new StreamReader(rutaFichero);
                cabeceras = SR.ReadLine().Split(';').ToList();

                int cont = 2;
                bool errores = false;

                do
                {
                    int year = 0;

                    if (!int.TryParse(cabeceras[cont].Split("_")[1], out year) || year < 2000 || year > 2023)
                    {
                        errores = true;
                        cabeceras.Clear();
                    }
                    cont++;
                } while (cont < cabeceras.Count && !errores);
                SR.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error al leer el archivo {rutaFichero}");
            }
            return cabeceras;
        }

        public static bool ComprobarMunicipios(string rutaFichero)
        {
            // declaramos las variables
            bool correcto = true;
            StreamReader SR;

            try
            {
                SR = new StreamReader(rutaFichero);
                SR.ReadLine();

                while (!SR.EndOfStream && correcto)
                {
                    if (SR.ReadLine().Split(';')[1].Trim() =="")
                    {
                        correcto = false;
                    }
                    
                }
            SR.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error! al leer el archivo {rutaFichero}");
            }
            return correcto;
        }

        public static List<string> ObtenerContenido(string rutaFichero)
        {
            // Declaramos las variables
            List<string> contenidoPoblaciones = new List<string>();
            StreamReader SR;

            try
            {
                SR = new StreamReader(rutaFichero);
                SR.ReadLine();
                bool correcto = true;

                while (!SR.EndOfStream && correcto) // Recorreremos las lineas del fichero hasta el final
                {
                    string linea = SR.ReadLine();
                    string[] lineaCompeta = linea.Split(';');
                    int contador = 2;

                    do
                    {
                        if (!int.TryParse(lineaCompeta[contador], out int dato) || dato < 0)
                        {
                            correcto = false;
                        }
                        contador++;
                    } while (contador < lineaCompeta.Length && correcto);

                    if (correcto)
                        contenidoPoblaciones.Add(linea);
                    else
                        contenidoPoblaciones.Clear();
                }
                SR.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error al leer el archivo {rutaFichero}");
            }
            return contenidoPoblaciones;
        }

        public static void CrearFicheroSalida(string ficheroSalida, List<string> contenidoPoblaciones, List<string> cabeceras)
        {
            // Declaramos las variables 
            StreamWriter SW;

            try
            {
                SW = new StreamWriter(ficheroSalida);

                foreach (string fila in contenidoPoblaciones)
                {
                    SW.WriteLine(GeneraLineaFinal(fila, cabeceras));
                }
                SW.Close();

            }
            catch (Exception Ex)
            {
                Console.WriteLine("Ha ocurrido un error ");
            }
        }
        private static string GeneraLineaFinal(string fila, List<string> cabeceras)
        {
            string filaFinal = "Municipio;AñoMin;ValorMin;AñoMax;ValorMax;Media";
            string[] valoresFila = fila.Split(";");
            int maxValue, maxPos = 2, minValue, minPos = 2;
            decimal suma = 0.0m;

            maxValue = int.Parse(valoresFila[2]);
            minValue = int.Parse(valoresFila[2]);
            suma += int.Parse(valoresFila[2]);
            for (int i = 3; i < valoresFila.Length; i++) //Recorre las posiciones de una fila
            {
                if (int.Parse(valoresFila[i]) > maxValue)
                {
                    maxValue = int.Parse(valoresFila[i]);
                    maxPos = i;
                }
                if (int.Parse(valoresFila[i]) < minValue)
                {
                    minValue = int.Parse(valoresFila[i]);
                    minPos = i;
                }
                suma += int.Parse(valoresFila[i]);
            }

            filaFinal = valoresFila[1] + ";" + cabeceras[minPos].Split("_")[1] + ";" + minValue + ";" + cabeceras[maxPos].Split("_")[1] + ";" + maxValue + ";" + Math.Round(suma / (valoresFila.Length - 2), 2);

            return filaFinal;
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error calculando la media mínima.");
            }

            return minMedia;
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
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al obtener los municipios mayores a la media introducida");
            }

            return muncipiosMayores;
        }

        public static void SolicitarDatoAlUsuario(string ficheroFinal)
        {
            decimal minMedia = GetMinMedia(ficheroFinal);
            decimal maxMedia = GetMaxMedia(ficheroFinal);
            decimal media = 0;

            Console.WriteLine("Introduzca un valor entre {0} y {1}:", minMedia, maxMedia);

            while (!decimal.TryParse(Console.ReadLine(), out media) || media < minMedia || media > maxMedia)
            {
                Console.WriteLine("El valor introducido ha de ser numérico y entre los valores {0} y {1}", minMedia, maxMedia);
            }

            List<string> municipiosMayores = GetOverMedia(media, ficheroFinal);

            foreach (string municipiosMayor in municipiosMayores)
            {
                Console.WriteLine(municipiosMayor);
            }

            Console.WriteLine("\nAdios...");
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error calculando la media mínima.");
            }

            return maxMedia;
        }
    }
}
