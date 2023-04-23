using System;
namespace ejerexam
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Declaramos las variables
            const string RUTA_FICHERO_POBLACIONES = "..\\..\\..\\poblacion-cifras-absolutas.csv";
            const string SALIDA = "..\\..\\..\\poblacion_datos_procesados.csv";

            if (Funciones.FicheroExiste(RUTA_FICHERO_POBLACIONES))
            {
                List<string> cabeceras = Funciones.ComprobarCabeceras(RUTA_FICHERO_POBLACIONES);
                if (cabeceras.Count > 0)
                {
                    if (Funciones.ComprobarMunicipios(RUTA_FICHERO_POBLACIONES))
                    {
                        List<string> contenido = Funciones.ObtenerContenido(RUTA_FICHERO_POBLACIONES);

                        if (contenido.Count > 0)
                        {
                            Funciones.CrearFicheroSalida(SALIDA, contenido, cabeceras);
                            Funciones.SolicitarDatoAlUsuario(SALIDA);
                        }
                        else
                        {
                            Console.WriteLine("Ha ocurrido un error en los datos de las poblaciones");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ha ocurrido un error con alguno de los municipios");
                    }
                }
                else
                {
                    Console.WriteLine($"Hay un dato invalido en las cabeceras del fichero {RUTA_FICHERO_POBLACIONES}");
                }
            }
            else
            {
                Console.WriteLine($"Ha ocurrido un error al encontrar el fichero {RUTA_FICHERO_POBLACIONES}");
            }
        }

        
    }
}
