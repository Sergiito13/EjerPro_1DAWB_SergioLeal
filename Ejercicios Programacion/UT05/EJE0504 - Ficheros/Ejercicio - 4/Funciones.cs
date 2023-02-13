using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Funciones
    {
        public const string NOMBREFICH1 = "Fichero1.txt";
        public const string NOMBREFICH2 = "Fichero2.txt";
        public const string NOMBREFICHSALIDA = "FicheroSalida.txt";

        public static void LeerFicheros()
        {
            //Declaramos las variables
            StreamReader sread1 = null;
            StreamReader sread2 = null;
            StreamWriter swriter1 = null;
            string Linea1 = "", Linea2 = "";

            try
            {
                sread1 = new StreamReader(NOMBREFICH1);
                sread2 = new StreamReader(NOMBREFICH2);

                if (!File.Exists(NOMBREFICHSALIDA))
                {
                    swriter1 = File.CreateText(NOMBREFICHSALIDA);
                }

                swriter1 = new StreamWriter(NOMBREFICHSALIDA);

                Linea1 = sread1.ReadLine();
                Linea2= sread2.ReadLine();

                
                while ((!sread1.EndOfStream) || (!sread2.EndOfStream))
                {
                    if (Linea1 != null)
                    {
                        swriter1.WriteLine(Linea1);
                        Linea1 = sread1.ReadLine();
                    }
                    if (Linea2 != null)
                    {
                        swriter1.WriteLine(Linea2);
                        Linea2= sread2.ReadLine();
                    }
                }
                sread1.Close();
                sread2.Close();
                swriter1.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void MostrarFicheroEscritura()
        {
            // Declaramos las variables

            StreamReader read = null;

            try
            {
                read = new StreamReader(NOMBREFICHSALIDA);
                while (!read.EndOfStream)
                {
                    Console.WriteLine(read.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
