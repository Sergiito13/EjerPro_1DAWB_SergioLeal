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
            double numerosFicheros = 0;
            string[] nombreMunicipio = new string[0];
            bool error = false;
            List<mediaMunicipios> datosMunicipio = new List<mediaMunicipios>();
            StreamReader SRead = null;
            StreamWriter sWriter = null;

            try
            {
                SRead = new StreamReader(NOMBREFICHEROPRINCIPALCSV);

                Utils.ComprobarSiexisteFicheroLog();

                sWriter = new StreamWriter(RUTAFICHEROLOG);

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
                                        datosMunicipio.Add(new mediaMunicipios { municipio = lineaContenido[1], mediaMunicipio = numerosFicheros });
                                        contadorColumnas++;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Error en la linea {contadorLinea}.La media no es valida (El numero es negativo)");
                                        sWriter.WriteLine($"Error en la linea {contadorLinea}.La media no es valida (El numero es negativo)");
                                        error = true;
                                        contadorColumnas = lineaContenido.Length;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Error en la linea {contadorLinea}.La media no es valida (No se puede convertir en double)");
                                    sWriter.WriteLine($"Error en la linea {contadorLinea}.La media no es valida (No se puede convertir en double)");
                                    error = true;
                                    contadorColumnas = lineaContenido.Length;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Error en la linea {contadorLinea}.(No hay datos para todos los años)");
                                sWriter.WriteLine($"Error en la linea {contadorLinea}.(No hay datos para todos los años)");
                                error = true;
                                contadorColumnas = lineaContenido.Length;
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
                sWriter.Close();
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }

            return datosMunicipio;
        }

        public static void ComprobarSiexisteFicheroLog() // ESTA FUNCION COMPROBARA SI EXISTE EL ARCHIVO LOGS SI NO LO CREARA
        {
            // Declaramos las variables
            const string RUTAFICHEROLOG = "..\\..\\..\\errores.log";

            if (!File.Exists(RUTAFICHEROLOG))
            {
                try
                {
                    File.CreateText(RUTAFICHEROLOG);
                }
                catch (Exception EX)
                {
                    Console.WriteLine(EX.Message);
                }
            }
        }

        public static void ComprobarSiexisteMediaPoblacionFichero() // ESTA FUNCION COMPROBARA SI EXISTE EL ARCHIVO media_poblacion.csv SI NO LO CREARA
        {
            // Declaramos las variables
            const string RUTAFICHEROMEDIAPOBLACION = "..\\..\\..\\media_poblacion.csv";

            if (!File.Exists(RUTAFICHEROMEDIAPOBLACION))
            {
                try
                {
                    File.CreateText(RUTAFICHEROMEDIAPOBLACION);
                }
                catch (Exception EX)
                {
                    Console.WriteLine(EX.Message);
                }
            }
        }
    
        public static void EscribirDatosFicheroMedias(List<mediaMunicipios> mediaMunicipios) // ESTA FUNCION ESCRIBIRA EL FICHERO MEDIA_POBLACION.CSV
        {
            // Declaramos las variables
            StreamWriter SWriter = null;
            double media = 0;
            const string RUTAFICHEROMEDIAPOBLACION = "..\\..\\..\\media_poblacion.csv";


            Utils.ComprobarSiexisteMediaPoblacionFichero();
            try
            {
                SWriter = new StreamWriter(RUTAFICHEROMEDIAPOBLACION);

                for (int i = 0; i < mediaMunicipios.Count; i++)
                {
                    media += mediaMunicipios[i].mediaMunicipio;  
                }

                media /= mediaMunicipios.Count;

                for (int i = 0; i < mediaMunicipios.Count; i++)
                {
                    media += mediaMunicipios[i].mediaMunicipio;
                    SWriter.WriteLine($" {mediaMunicipios[i].municipio};{media}");
                }
                
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
                throw;
            }
        }
    }
}
