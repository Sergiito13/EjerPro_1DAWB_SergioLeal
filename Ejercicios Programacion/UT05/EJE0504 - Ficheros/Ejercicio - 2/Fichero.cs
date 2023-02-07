namespace Ejercicio2Fichero
{
    class Fichero
    {
        public const string NOMBREFICHERO = "Ejercicio2.txt"; 
        public static void CrearFichero() // ESTA FUNCION CREARA EL ARCHIVO 
        {
            // Declramos las variables
            string nombrefichero = "", EleccionUsuario = "";
            

            Console.WriteLine("\n");

            if (!File.Exists(NOMBREFICHERO))
            {

            }
            else
            {
                Console.WriteLine("El fichero ya existe ¿Quieres sobreescribirlo?");
                EleccionUsuario = Console.ReadLine();
            }

            
        }

        public static void IntroducirValoresFichero()
        {

        }

        public static void ValorMaximoFichero()
        {

        }

        public static void ValorMinimoFichero()
        {

        }

        public static void CalcularMediaFichero()
        {

        }


    }
}
