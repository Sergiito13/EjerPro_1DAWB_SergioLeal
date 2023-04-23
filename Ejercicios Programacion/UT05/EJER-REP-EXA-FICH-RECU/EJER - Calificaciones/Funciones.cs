using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercalificaciones
{
    class Funciones
    {
        // Declaramos las variables

        public static bool ComprobarFicheroExiste(string fichero)
        {
            // Declaramos las variables
            bool existe = true;

            if (!File.Exists(fichero))
            {
                existe= false;
            }
            return existe;

        }

        public static List<string> MeterDatosLista(string fichero)
        {
            // Declaramos las variables
            List<string> datosAlumnos = new List<string>();
            StreamReader SR;

            try
            {
                SR = new StreamReader(fichero);
                SR.ReadLine();

                while (!SR.EndOfStream)
                {
                    string linea = SR.ReadLine();
                    string[] lineaCompleta = linea.Split(';');

                    for (int i = 0; i < lineaCompleta.Length; i++)
                    {
                        datosAlumnos.Add(lineaCompleta[i]);
                    }
                    
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error al leer el fichero {fichero}");
            }

            /*foreach (string alumno in datosAlumnos)
            {
                Console.WriteLine(alumno);
            }*/
            
            /*datosAlumnos = Funciones.OrdenarListaPorApellidos( datosAlumnos );*/
            return datosAlumnos;
        }

        public static List<string> OrdenarListaPorApellidos(List<string> datosAlumnos)
        {
            datosAlumnos = datosAlumnos.OrderBy(apellido => apellido.Split(';')[0]).ToList();

            foreach (string alumno in datosAlumnos)
            {
                Console.WriteLine(alumno);
            }
            return datosAlumnos;
        }

        public static List<string> SacarNotaFinalCadaAlumno(List<string> datosAlumnos)
        {
            // Declaramos las variables
            decimal notaFinal = 0, nota1 = 0, nota2 = 0, notaPractica = 0 ;
            for (int i = 0; i < datosAlumnos.Count; i+=10)
            {
                nota1 =0; nota2 = 0; notaPractica = 0;notaFinal = 0;

                nota1 = string.IsNullOrEmpty(datosAlumnos[i + 3]) ? 0 : Convert.ToDecimal(datosAlumnos[i + 3]);
                nota2 = string.IsNullOrEmpty(datosAlumnos[i + 4]) ? 0 : Convert.ToDecimal(datosAlumnos[i + 4]);
                notaPractica = string.IsNullOrEmpty(datosAlumnos[i + 7]) ? 0 : Convert.ToDecimal(datosAlumnos[i + 7]);

                notaFinal = Math.Round((nota1 * 0.3m) + (nota2 * 0.3m) + (notaPractica * 0.4m), 2);
                datosAlumnos.Insert(i+9,Convert.ToString(notaFinal));
            }
            return datosAlumnos;
        }

        public static List<string> AlumnosSuspendidos(List<string> datosAlumnos)
        {
            // Declaramos las variables
            List<string> alumnosSuspendidos = new List<string>();

            for (int i = 0; i < datosAlumnos.Count; i+=10)
            {
                if (datosAlumnos[i+2] >= "75")
                {

                }
            }
        }
    }
}
