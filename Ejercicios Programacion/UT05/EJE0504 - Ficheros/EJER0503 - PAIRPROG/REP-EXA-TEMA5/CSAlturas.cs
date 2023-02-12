using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPAIRPROGRAMING
{
    class CSAlturas
    {
        public static Decimal Media(Personal.Personas[] ListaPersonas) //ESTA FUNCION CALCULARA LA MEDIA DE LAS ALTURAS
        {
            // Declaramos las variables
            decimal MediaAlturas = 0, Divisor = ListaPersonas.Length;
           
            for (int i = 0; i < ListaPersonas.Length; i++)
            {
                MediaAlturas += (ListaPersonas[i].Altura) / Divisor;
            }
            return MediaAlturas;
        } 
    
        public static string[] PersonasPorEncimaMedia(Personal.Personas[] ListaPersonas, decimal Media)// ESTA FUNCION CALCULARA LAS PERSONAS QUE ESTAN POR ENCIMA DE LA MEDIA
        {
            // Declaramos las variables

        }
    }
}
