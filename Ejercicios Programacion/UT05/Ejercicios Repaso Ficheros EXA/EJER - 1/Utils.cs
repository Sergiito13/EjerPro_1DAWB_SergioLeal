using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    class Utils
    {
        public static string PedirFraseParaFichero() // Esta funcion pedira una frase para el fichero
        {
            // Declaramos las variables
            string fraseUsuario = "";

            bool salir = false;

            do
            {
                Console.WriteLine("Dime una frase que se guardara en el fichero");
                fraseUsuario = Console.ReadLine();

                if (fraseUsuario.Length > 0)
                {
                    salir = true;
                }
                else
                {
                    Console.WriteLine("Error ! La cadena no puede estar vacio");
                }

            } while (!salir);
            return fraseUsuario;
        }

        public static void MeterDatosFichero() // Esta funcion ingresara las frases en el fichero a menos que se escriba fin
        {
            // Declaramos las variables
            const string NOMBRE_FICHERO_REGISTROUSUARIO = "..\\..\\..\\registroDeUsuario.txt";
            string fraseUsuario = "";
            StreamWriter SWriter = null;
            StreamWriter SWCreate = null;
            bool salir = false;

            try
            {
                if (!File.Exists(NOMBRE_FICHERO_REGISTROUSUARIO))
                {
                    SWCreate = File.CreateText(NOMBRE_FICHERO_REGISTROUSUARIO);
                    SWCreate.Close();
                }
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            

            do
            {
                fraseUsuario = PedirFraseParaFichero();

                try
                {
                    SWriter = new StreamWriter(NOMBRE_FICHERO_REGISTROUSUARIO , true);

                    if ((fraseUsuario == "Fin") || (fraseUsuario == "FIN") || (fraseUsuario == "FIn") || (fraseUsuario == "FiN") ||(fraseUsuario == "fin"))
                    {
                        salir = true;
                        SWriter.Close();
                        MostrarDatosFicheroEscrito();
                    }
                    else
                    {
                        SWriter.WriteLine(fraseUsuario);
                        SWriter.Close();
                        
                    }
                }
                catch (Exception EX)
                {
                    Console.WriteLine(EX.Message);
                }
                
            } while (!salir);
            





        }
    
        public static void MostrarDatosFicheroEscrito() // Esta funcion mostrara los datos ecritos en el fichero
        {
            // Declaramos las variables
            const string NOMBRE_FICHERO_REGISTROUSUARIO = "..\\..\\..\\registroDeUsuario.txt";
            StreamReader SRead = null;

            try
            {
                SRead = new StreamReader(NOMBRE_FICHERO_REGISTROUSUARIO);
                Console.WriteLine("Los datos del fichero son: ");
                Console.WriteLine("");
                while (!SRead.EndOfStream)
                {
                    Console.WriteLine(SRead.ReadLine());
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

        }
    }
}
