using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public struct Alumnos
    {
       public string Nombre;
       public string Apellidos;
       public int NotaPrimeraEva;
       public int NotaSegundaEva;
       public int NotaTerceraEva;
       
    }

    class Funciones
    {

        public const string NOMBREFITCH = "Fichero3.txt";

        public static Alumnos[] LeerDatosFichero() // ESTA FUNCION LEE LOS DATOS DEL FICHERO Y LO METE EN LA ESTRUCTURA
        {
            // Declaramos las variables
            StreamReader SRead = null;
            string[] Datos = new string[0];
            string Lineas = "";
            int Contador = 0;

            try
            {
                SRead = new StreamReader(NOMBREFITCH);

                Lineas = SRead.ReadLine();

                while (!SRead.EndOfStream)
                {
                    Lineas+= SRead.ReadLine();
                }
                Datos = Lineas.Split(',');
                SRead.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
            Alumnos[] Alumnos = new Alumnos[0];
            
            for (int i = 0; i < Datos.Length; i+=5)
            {
                if (i < Datos.Length-1)
                {
                    Array.Resize(ref Alumnos, Alumnos.Length + 1);
                    Alumnos[Contador].Nombre = Datos[i];
                    Alumnos[Contador].Apellidos = Datos[i + 1];
                    Alumnos[Contador].NotaPrimeraEva = int.Parse(Datos[i + 2]);
                    Alumnos[Contador].NotaSegundaEva = int.Parse(Datos[i + 3]);
                    Alumnos[Contador].NotaTerceraEva = int.Parse(Datos[i + 4]);

                    
                }
        
                Contador++;
            }
            return Alumnos;
        }

        public static void MostrarContenidoEstructura(Alumnos[] Alumnos) // ESTA FUNCION MOSTRARA EL CONTENIDO DE LA ESTRUCTURA
        {
            // Declaramos las variables

            Console.WriteLine("Los datos de la estructura son;");
            for (int i = 0; i < Alumnos.Length; i++)
            {
                Console.Write($"\n {Alumnos[i].Nombre} ");
                Console.Write($" {Alumnos[i].Apellidos} ");
                Console.Write($" {Alumnos[i].NotaPrimeraEva} ");
                Console.Write($" {Alumnos[i].NotaSegundaEva} ");
                Console.Write($" {Alumnos[i].NotaTerceraEva} ");
                
            }
            Console.WriteLine("\n");
        }
    
        public static string[] CalcularAlumnosSuspendidos(Alumnos[] Alumnos) // ESTA FUNCION COGERA EL NOMBRE DE LOS ALUMNOS QUE TENGAN LAS 3 EVALUACIONES SUSPENDIDAS
        {
            // Declaramos las variables
            string[] NombreSuspendidos = new string[0];
            int Contador = 0;

            for (int i = 0; i < Alumnos.Length; i++)
            {
                if ((Alumnos[i].NotaPrimeraEva < 5) && (Alumnos[i].NotaSegundaEva < 5) && (Alumnos[i].NotaTerceraEva < 5))
                {
                    Array.Resize(ref NombreSuspendidos, NombreSuspendidos.Length+1);
                    NombreSuspendidos[Contador] = Alumnos[i].Nombre;
                    Contador++;
                }
            }
            return NombreSuspendidos;
        }
    
        public static void MostrarAlumnosSuspendidos3Eva(Alumnos[] Alumnos, string[] NombreAlumno) // ESTA FUNCION MOSTRARA LOS ALUMNOS CON LAS 3 EVA SUSPENDIDADS
        {
            // Declaramos las variables
            int Contador = 0;
            Console.WriteLine("\n----------------------------------------------------");
            Console.WriteLine("Los alumnos que suspendieron las 3 evaluaciones son: ");
            for (int i = 0; i < Alumnos.Length; i++)
            {
                Contador = 0;
                while (Contador < NombreAlumno.Length)
                {
                    if (Alumnos[i].Nombre == NombreAlumno[Contador])
                    {
                        Console.Write($"\n {Alumnos[i].Nombre} ");
                        Console.Write($" {Alumnos[i].Apellidos} ");
                        Console.Write($" {Alumnos[i].NotaPrimeraEva} ");
                        Console.Write($" {Alumnos[i].NotaSegundaEva} ");
                        Console.Write($" {Alumnos[i].NotaTerceraEva} ");
                        Contador= NombreAlumno.Length;
                    }
                    else
                    {
                        Contador++;
                    }
                }
                    
            }
            Console.WriteLine("");
        }
    }
}
