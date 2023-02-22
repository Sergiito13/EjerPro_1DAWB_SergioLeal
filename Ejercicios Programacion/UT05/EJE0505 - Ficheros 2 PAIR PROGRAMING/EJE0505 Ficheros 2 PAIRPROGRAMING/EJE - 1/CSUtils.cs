using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesEjercicioFich
{
    class CSFunciones
    {
        public const string RUTAFICHERO1 = "..\\..\\..\\1.txt";
        public const string RUTAFICHERO2 = "..\\..\\..\\2.txt";
        public const string RUTAFICHERODIFERENCIAS = "Diferencias.txt";

        public static void LeerFicherosyEscribirEnOtro()
        {
            // Declaramos las variables
            string Linea1 = "", Linea2 = "";
            int ContadorLinea = 0, ContadorLineaIguales = 0;
            StreamReader SRead1 = null;
            StreamReader SRead2 = null;
            StreamWriter Swrite = null;
            StreamWriter Swrite2 = null;


            try
            {

                SRead1 = new StreamReader(RUTAFICHERO1);
                SRead2 = new StreamReader(RUTAFICHERO2);
                Swrite = new StreamWriter(RUTAFICHERODIFERENCIAS);

                if (File.Exists(RUTAFICHERODIFERENCIAS))
                {
                    
                }
                else
                {

                    Swrite2 = File.CreateText(RUTAFICHERO2);
                    Swrite2.Close();
                    Console.WriteLine("El fichero se ha creado correctamente");
                }

                while ((!SRead1.EndOfStream) || (!SRead2.EndOfStream))
                {
                    Linea1 = SRead1.ReadLine();
                    Linea2 = SRead2.ReadLine();
                    ContadorLinea++;

                    if (Linea1 != Linea2)
                    {
                        Swrite.WriteLine($"{ContadorLinea};{Linea1};{Linea2}");
                        
                    }
                    else
                    {
                        ContadorLineaIguales++;
                    }
                }

                Console.WriteLine($"El número de lineas que son iguales es de: {ContadorLineaIguales} lineas");
                SRead1.Close();
                SRead2.Close();
                Swrite.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void MostrarFicheroFinal()
        {
            // Declaramos las variables
            StreamReader sread = null;

            try
            {
                sread = new StreamReader(RUTAFICHERODIFERENCIAS);
                

                Console.WriteLine("\nEl contenido del fichero final es:");
                while (!sread.EndOfStream)
                {
                    string Linea = sread.ReadLine();
                    Console.WriteLine(Linea);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
