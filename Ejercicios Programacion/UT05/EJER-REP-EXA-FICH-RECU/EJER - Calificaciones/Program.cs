using System;
namespace ejercalificaciones
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // Declaramos las variables
            const string RUTA_FICHERO = "..\\..\\..\\calificaciones.csv";
            bool existe = false;
            
            if (existe = Funciones.ComprobarFicheroExiste(RUTA_FICHERO))
            {
                List<string> datosAlumnos = Funciones.MeterDatosLista(RUTA_FICHERO);
                if (datosAlumnos.Count > 0)
                {
                    Funciones.SacarNotaFinalCadaAlumno(datosAlumnos);
                }
            }
            else
            {
                Console.WriteLine("El fichero no existe");
            }
        }
    }
}
