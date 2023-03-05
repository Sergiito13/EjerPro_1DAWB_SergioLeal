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
            string lineasFichero = "";
            int contadorLinea = 1, contadorPosiciones = 0;
            double numerosFicheros = 0;
            string[] nombreMunicipio = new string[0];
            bool error = false;
            List<mediaMunicipios> datosMunicipio = new List<mediaMunicipios>();
            StreamReader SRead = null;

            try
            {
                SRead = new StreamReader(NOMBREFICHEROPRINCIPALCSV);

                while ((!SRead.EndOfStream) && (!error))
                {
                    lineasFichero = SRead.ReadLine();
                    string[] lineaContenido = lineasFichero.Split(";");

                    if (contadorLinea >= 2)
                    {
                        for (int i = 2; i < lineaContenido.Length; i++)
                        {
                            if (lineaContenido[i] == " ")
                            {
                                if (double.TryParse(lineaContenido[i], out numerosFicheros))
                                {
                                    if (numerosFicheros > 0)
                                    {
                                        datosMunicipio.Add(new mediaMunicipios { municipio = lineaContenido[1], mediaMunicipio = numerosFicheros });
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Error en la linea {contadorLinea}.La media no es valida (El numero es negativo)");
                                        error = true;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Error en la linea {contadorLinea}.La media no es valida (No se puede convertir en double)");
                                    error = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Error en la linea {contadorLinea}.No hay datos para todos los años)");
                                error = true;
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

                foreach (mediaMunicipios datos in datosMunicipio)
                {
                    Console.Write(datos.municipio);
                    Console.Write(datos.mediaMunicipio);
                }
                Console.WriteLine("");




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
    }
}
