using System.Runtime.InteropServices;

namespace EjerFicheros
{
    public struct mediaMunicipios
    {
        public string municipio;
        public double mediaMunicipio;
    }

    class Utils
    {
        public static List<mediaMunicipios> LeerDatosFichero() // ESTA FUNCION PROCESARA LOS DATOS Y LO GUARDARA EN LISTAS, SI ENCUENTRA ALGUN ERROR LO ESCRIBIRA EN EL FICHERO LOGS
        {
            // Declaramos las variables
            const string NOMBREFICHEROPRINCIPALCSV = "..\\..\\..\\edades-medias-de-la-poblacion.csv";
            const string RUTAFICHEROLOG = "..\\..\\..\\errores.log";
            string lineasFichero = "";
            int contadorLinea = 1, contadorPosiciones = 0, contadorColumnas = 0;
            double numerosFicheros = 0,media = 0;
            string[] nombreMunicipio = new string[0];
            bool error = false;
            List<mediaMunicipios> datosMunicipio = new List<mediaMunicipios>();
            StreamReader SRead = null;
            StreamWriter sWriter = null;

            try
            {
               
                SRead = new StreamReader(NOMBREFICHEROPRINCIPALCSV);

                

                while ((!SRead.EndOfStream) && (!error))
                {
                    lineasFichero = SRead.ReadLine();
                    string[] lineaContenido = lineasFichero.Split(";");

                    if (contadorLinea >= 2)
                    {
                        contadorColumnas = 2;
                        while (contadorColumnas < lineaContenido.Length)
                        {
                            if (lineaContenido[contadorColumnas] != " ")
                            {
                                if (double.TryParse(lineaContenido[contadorColumnas], out numerosFicheros))
                                {
                                    if (numerosFicheros > 0)
                                    {
                                        media += numerosFicheros;
                                        
                                        if (contadorColumnas == lineaContenido.Length-1)
                                        {
                                            media /= lineaContenido.Length-2;
                                            media = Math.Round(media,2);
                                            datosMunicipio.Add(new mediaMunicipios { municipio = lineaContenido[1], mediaMunicipio = media });
                                        }
                                        contadorColumnas++;
                                    }
                                    else
                                    {
                                        Utils.CrearFicheroLogs();
                                        sWriter = new StreamWriter(RUTAFICHEROLOG);

                                        sWriter.WriteLine($"Error en la linea {contadorLinea}.La media no es valida (El numero es negativo)");
                                        error = true;
                                        contadorColumnas = lineaContenido.Length;
                                        sWriter.Close();
                                    }
                                }
                                else
                                {
                                    Utils.CrearFicheroLogs();
                                    sWriter = new StreamWriter(RUTAFICHEROLOG);

                                    sWriter.WriteLine($"Error en la linea {contadorLinea}.La media no es valida (No se puede convertir en double)");
                                    error = true;
                                    contadorColumnas = lineaContenido.Length;
                                    sWriter.Close();
                                }
                            }
                            else
                            {
                                Utils.CrearFicheroLogs();
                                sWriter = new StreamWriter(RUTAFICHEROLOG);

                                sWriter.WriteLine($"Error en la linea {contadorLinea}.(No hay datos para todos los años)");
                                error = true;
                                contadorColumnas = lineaContenido.Length;
                                sWriter.Close();
                            }
                        }
                        contadorLinea++;
                    }
                    else
                    {
                        contadorLinea++;
                    }

                }
                SRead.Close();
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

            return datosMunicipio;
        }
    
        public static void CrearFicheroLogs()// ESTA FUNCION CREA EL FICHERO .LOGS
        {
            // Declaramos las variables
            StreamWriter SWRITER = null;
            const string NOMBRE_FICHERO_LOGS = "..\\..\\..\\errores.log";

            try
            {
                SWRITER = File.CreateText(NOMBRE_FICHERO_LOGS);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            SWRITER.Close();
        }

        public static void CrearFicheroMediasPoblacion()// ESTA FUNCION CREA EL FICHERO .LOGS
        {
            // Declaramos las variables
            StreamWriter SWRITER = null;
            const string NOMBRE_FICHERO_MediaPoblacion = "..\\..\\..\\media_poblacion.csv";

            try
            {
                SWRITER = File.CreateText(NOMBRE_FICHERO_MediaPoblacion);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            SWRITER.Close();
        }
        public static void EscribirDatosFicheroMedias(List<mediaMunicipios> mediaMunicipios) // ESTA FUNCION ESCRIBIRA EL FICHERO MEDIA_POBLACION.CSV
        {
            // Declaramos las variables
            StreamWriter SWriter = null;
            StreamWriter SWriter2 = null;
            const string RUTAFICHEROMEDIAPOBLACION = "..\\..\\..\\media_poblacion.csv";

            try
            {
                Utils.CrearFicheroMediasPoblacion();
                SWriter = new StreamWriter(RUTAFICHEROMEDIAPOBLACION);
                

                for (int i = 0; i < mediaMunicipios.Count; i++)
                {
                    SWriter.WriteLine($" {mediaMunicipios[i].municipio};{mediaMunicipios[i].mediaMunicipio}");
                }
                SWriter.Close();
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            
        }

        public static void MostrarResultadoFicheroMediaPoblacion() // ESTA FUNCION MOSTRARA EL ARCHIVO MEDIAPOBLACION
        {
            // Declaramos las variables
            StreamReader SREAD = null;
            const string RUTAFICHEROMEDIAPOBLACION = "..\\..\\..\\media_poblacion.csv";

            try
            {
                SREAD = new StreamReader(RUTAFICHEROMEDIAPOBLACION);
                Console.WriteLine("El fichero se ha generado correctamente y los datos son: ");
                Console.WriteLine("");
                string Linea = "";

                while (!SREAD.EndOfStream)
                {
                    Linea = SREAD.ReadLine();
                    Console.WriteLine(Linea);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void MostrarResultadoFicherologs() // ESTA FUNCION MOSTRARA EL ARCHIVO MEDIAPOBLACION
        {
            // Declaramos las variables
            StreamReader SREAD = null;
            const string RUTAFICHEROERRORES = "..\\..\\..\\errores.log";
            string Linea = "";

            try
            {
                SREAD = new StreamReader(RUTAFICHEROERRORES);
                Console.WriteLine("El fichero no se pudo completar con exito. Le mostrare el contenido del archivo.log: ");
                Console.WriteLine("");

                while (!SREAD.EndOfStream)
                {
                    Linea = SREAD.ReadLine();
                    Console.WriteLine(Linea);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
