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
        public const string RUTAFICHERODIFERENCIAS = "..\\..\\..\\Diferencias.txt";

        public static void LeerFicherosyEscribirEnOtro()
        {
            // Declaramos las variables
            string Linea1 = "", Linea2 = "";
            int ContadorLinea = 0, ContadorLineaIguales = 0;
            StreamReader SRead1 = null;
            StreamReader SRead2 = null;
            StreamWriter Swrite = null;
           

            try
            {
                SRead1 = new StreamReader(RUTAFICHERO1);
                SRead2 = new StreamReader(RUTAFICHERO2);

                

                while ((!SRead1.EndOfStream) || (!SRead2.EndOfStream))
                {
                    Linea1 = SRead1.ReadLine();
                    Linea2 = SRead2.ReadLine();
                    ContadorLinea++;

                    if (Linea1 != Linea2)
                    {
                        if (File.Exists(RUTAFICHERODIFERENCIAS))
                        {
                            Swrite.WriteLine($"{ContadorLinea};{Linea1};{Linea2}");
                        }
                        else
                        {
                            Console.WriteLine("El fichero se ha creado correctamente");
                            Swrite = File.CreateText(RUTAFICHERO2);
                            Swrite.WriteLine($"{ContadorLinea};{Linea1};{Linea2}");
                        }
                        
                    }
                    else
                    {
                        ContadorLineaIguales++;

                    }
                }
                Console.WriteLine($"El número de lineas que son iguales es de: {ContadorLineaIguales} lineas");
                Swrite.Close();
                SRead1.Close();
                SRead2.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
