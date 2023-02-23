using EJE2FICHEROS;
using System;

namespace EJER2FICHEROS
{
    class Program
    {
        static void Main(string[] agrs)
        {
            // Declaramos las variables
            string NombreFich = "";
            int NumeroLineas = 0;
            
            NombreFich = Funciones.PedirNombreFichero();

            NumeroLineas = Funciones.PedirNumeroLineas();
        }
    }
}