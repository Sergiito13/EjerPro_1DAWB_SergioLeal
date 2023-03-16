namespace ExamenFicheros
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //1- Validar fichero de entrada (existencia, cabeceras, municipios y datos)
            //2- Generar contenido fichero final
            //3- Escribir el contenido en el fichero final
            //4- Calcular max y min de las medias del fichero final
            //5- Leer dato usuario y validarlo
            //6- Obtener las medias superiores y mostrarlas

            const string ENTRADA = "poblacion-cifras-absolutas.csv";
            const string SALIDA = "poblacion_datos_procesados.csv";

            if (File.Exists(ENTRADA))
            {
                List<string> cabeceras = Funciones.getCabeceras(ENTRADA);
                if (cabeceras.Count>0){
                    if (Funciones.municipiosCorrectos(ENTRADA))
                    {
                        //Valido los datos de poblaciones
                        List<string> contenidoFichero = Funciones.getContenido(ENTRADA);
                        if (contenidoFichero.Count > 0)
                        {
                            //Empieza la fiesta
                            Funciones.CrearFicheroSalida(SALIDA, contenidoFichero, cabeceras);
                            Funciones.SolicitarDatoAlUsuario(SALIDA);
                        }
                        else
                        {
                            Console.WriteLine("Algún dato de población es incorrecto");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error en los municipios del fichero de entrada");
                    }
                }
                else
                {
                    Console.WriteLine("Existe un error en los años de la cabeceras");
                }
            }
            else
            {
                Console.WriteLine("El fichero de entrada no existe");
            }
        }
    }
}