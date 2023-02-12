using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public struct Alumnos
    {
       public string[] Nombre;
       public string[] Apellidos;
       public int[] NotaPrimeraEva;
       public int[] NotaSegundaEva;
       public int[] NotaTerceraEva;
       
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
            string[] Nombres = new string[0];
            string[] Apellidos = new string[0];
            int[] Nota1 = new int[0];
            int[] Nota2 = new int[0];
            int[] Nota3 = new int[0];

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

            int Contador = 0;
            Alumnos[] Alumnos = new Alumnos[0];
            
            for (int i = 0; i < Datos.Length; i+=5)
            {

                if (i < Datos.Length-1)
                {
                    Array.Resize(ref Nombres, Nombres.Length + 1);
                    Array.Resize(ref Apellidos, Apellidos.Length + 1);
                    Array.Resize(ref Nota1, Nota1.Length + 1);
                    Array.Resize(ref Nota2, Nota2.Length + 1);
                    Array.Resize(ref Nota3, Nota3.Length + 1);

                    Nombres[Contador] = Datos[i];
                    Apellidos[Contador] = Datos[i + 1];
                    Nota1[Contador] = int.Parse(Datos[i + 2]);
                    Nota2[Contador] = int.Parse(Datos[i + 3]);
                    Nota3[Contador] = int.Parse(Datos[i + 4]);
                }
        
                Contador++;
                
            }

            Contador = 0;
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.Write($"\n {Nombres[i]} ");
                Console.Write($" {Apellidos[i]} ");
                Console.Write($" {Nota1[i]} ");
                Console.Write($" {Nota2[i]} ");
                Console.Write($" {Nota3[i]} ");

                //Alumnos[Contador].Nombre = Nombres[i];
                //Alumnos[Contador].Apellidos = Apellidos[i];
                //Alumnos[Contador].NotaPrimeraEva = Nota1[i];
                //Alumnos[Contador].NotaSegundaEva = Nota2[i];
                //Alumnos[Contador].NotaSegundaEva = Nota2[i];

                Contador++;

            }

            return Alumnos;
        }

    }
}
