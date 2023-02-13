using System;

namespace Ejercicio5
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Declaramos las variables
            string NombreFicheroOrigen = "", NombreFicheroDestino = "", ContenidoFicheroOrigen = "";

            NombreFicheroOrigen = Funciones.PedirNombreFicheroOrigen();

            NombreFicheroDestino = Funciones.PedirNombreFicheroDestino();

            ContenidoFicheroOrigen = Funciones.AbrirCopiarFicheroOrigen(NombreFicheroOrigen);

            Funciones.CrearFicheroDestino(NombreFicheroDestino);

            Funciones.CopiarContenidoFicheroDestino(NombreFicheroDestino, ContenidoFicheroOrigen);

            Funciones.MostrarContenidoFicheroDestino(NombreFicheroDestino);

        }
    }
}
