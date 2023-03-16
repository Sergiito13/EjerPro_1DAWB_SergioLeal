using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenfich
{
    internal class Funciones
    {
        // ↓ ESTA FUNCION TRATARA LA CABECERA Y COMPROBARA QUE SE PUEDE CONVERTIR EN TIPO INT Y QUE EL AÑO ESTE ENTRE 2000 Y 2023↓
        public static List<int> TratarCabeceraFichero(string nombreFichero)
        {
            // Declaramos las variables
            StreamReader SRead;
            bool error = false;
            List<string> lineaSeparada = new List<string>();
            List<int> años = new List<int>();
            int year = 0;

            try
            {
                SRead = new StreamReader(nombreFichero);
                string Linea = SRead.ReadLine();

                lineaSeparada = Linea.Split(";").ToList();

                int count = 2;
                while ((count < lineaSeparada.Count) && (!error))
                {
                    if (int.TryParse(lineaSeparada[count].Split("_")[1], out year) && (year >= 2000) && (year <= 2023))
                    {
                        años.Add(year);
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Ha ocurrido un error en alguno de los años de la cabecera");
                        error = true;
                        años.Clear();
                    }
                }

                SRead.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido algun problema con el fichero");
            }
            return años;
        }


        // ↓ ESTA FUNCION COMPROBARA QUE LOS MUNICIPIOS NO HAY NINGUNO VACIO ↓ 
        public static bool ComprobarMunicipioEsCorrecto(string nombreFichero)
        {
            // Declaramos las variables
            StreamReader SRead;
            bool error = false;
            string Linea = "", municipio = "";
            List<string> cadenaSeparada = new List<string>();

            try
            {
                SRead=new StreamReader(nombreFichero);
                SRead.ReadLine();

                while ((!SRead.EndOfStream) && (!error))
                {
                    Linea = SRead.ReadLine();
                    cadenaSeparada = Linea.Split(";").ToList();

                    if (string.IsNullOrEmpty(cadenaSeparada[1].Trim()))
                    {
                        Console.WriteLine("Error ha ocurrido un error, con un municipio");
                        error = true;
                    }
                }

                SRead.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error al leer el archivo origen");
            }
            return error;
        }

        // ↓ ESTA FUNCION COMPROBARA QUE LAS POBLACIONES NO HAYA NINGUN ERROR ↓
        public static bool SacarLasPoblacionesMunicipios(string nombreFichero)
        {
            // Declaramos las variables
            StreamReader SRead;
            bool error = false;
            string linea = "";
            int year = 0;
            List<string> lineaSeparada =new List<string>();

            try
            {
                SRead = new StreamReader(nombreFichero);
                SRead.ReadLine();

                while ((!SRead.EndOfStream)&& (!error))
                {
                    linea = SRead.ReadLine();
                    lineaSeparada = linea.Split(";").ToList();

                    int contador = 2;
                    while ((contador < lineaSeparada.Count) && (!error))
                    {
                        if (int.TryParse(lineaSeparada[contador], out year) )
                        {
                            if (year >= 0)
                            {
                                contador++;
                            }
                            else
                            {
                                Console.WriteLine("Error, algo ha salido mal con las poblaciones, tienen que ser entero y ser positivas");
                                error = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error, algo ha salido mal con las poblaciones, tienen que ser entero y ser positivas");
                            error=true;
                        }
                    }
                }

                SRead.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error, al leer el archivo");
                throw;
            }

            return error;
        }

        // 

        public static void EscribirDatosEnFicheroFinal(string nombreFichero)
        {
            // Declaramos las variables
            StreamReader SRead;
            StreamWriter SWrite;
            string linea = "";
            List<string> lineaSeparada = new List<string>();
            int maxAño = 0, minAño = 0;

            try
            {
                SRead = new StreamReader(nombreFichero);
                SRead.ReadLine();

                while (!SRead.EndOfStream)
                {
                    linea = SRead.ReadLine();
                    lineaSeparada = linea.Split(";").ToList();


                }


                SRead.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error");
                throw;
            }
        }
    }
}
