using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    internal class Funciones
    {
        public static bool PedirRespuestaSeguir()
        {
            //Declaremos las variables
            bool correcto = false, seguir = false;
            
            do
            {
                Console.WriteLine("¿Quieres añadir otro producto? [si | no]");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta == "si")
                {
                    seguir = true;
                    correcto = true;
                }
                else if (respuesta == "no")
                {
                    seguir = false;
                    correcto = true;
                }
                else
                {
                    Console.WriteLine("Error! La respuesta debe ser 'si' o 'no'");
                }

            } while (!correcto);
            return seguir;
        }
    }
}



