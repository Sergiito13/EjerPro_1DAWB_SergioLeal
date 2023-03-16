using System;
namespace examenfich
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // Declaramos las variables
            const string FICHERO_INICIAL_CIFRAS_ABSOLUTAS = "..\\..\\..\\poblacion-cifras-absolutas.csv";
            List<int> añosCabecera = new List<int>();

            if (File.Exists(FICHERO_INICIAL_CIFRAS_ABSOLUTAS))
            {

                añosCabecera = Funciones.TratarCabeceraFichero(FICHERO_INICIAL_CIFRAS_ABSOLUTAS);

                if (añosCabecera.Count > 0)
                {
                    if (!Funciones.ComprobarMunicipioEsCorrecto(FICHERO_INICIAL_CIFRAS_ABSOLUTAS))
                    {
                        if (!Funciones.SacarLasPoblacionesMunicipios(FICHERO_INICIAL_CIFRAS_ABSOLUTAS))
                        {

                        }
                        else
                        {
                            Console.WriteLine("Ha ocurrido un error con las poblaciones del fichero");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ha ocurrido un error con los municipios del fichero");
                    }

                }
                else
                {
                    Console.WriteLine("Ha ocurrido un error con las años de las cabeceras");
                }

            }
            else
            {
                Console.WriteLine("El fichero no existe");
            }
        }
    }
}