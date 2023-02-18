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
            Console.WriteLine($"\nLa media es: {MediaAlturas}");
            return MediaAlturas;
        }

        public static string[] PersonasPorEncimaMedia(Personal.Personas[] ListaPersonas, decimal Media)// ESTA FUNCION CALCULARA LAS PERSONAS QUE ESTAN POR ENCIMA DE LA MEDIA
        {
            // Declaramos las variables
            string[] NombrePersonasPorEncimaMedia = new string[0];
            int Contador = 0;

            for (int i = 0; i < ListaPersonas.Length; i++)
            {
                if (ListaPersonas[i].Altura > Media)
                {
                    Array.Resize(ref NombrePersonasPorEncimaMedia, NombrePersonasPorEncimaMedia.Length + 1);
                    NombrePersonasPorEncimaMedia[Contador] = ListaPersonas[i].Nombre;
                    Contador++;
                }
            }
            Console.WriteLine("EL NOMBRE DE LAS PERSONAS POR ENCIMA DE LA MEDIA ES");
            return NombrePersonasPorEncimaMedia;
        }

        public static string[] PersonasPorDebajoMedia(Personal.Personas[] ListaPersonas, decimal Media)// ESTA FUNCION CALCULARA LAS PERSONAS QUE ESTAN POR ENCIMA DE LA MEDIA
        {
            // Declaramos las variables
            string[] NombrePersonasPorDebajoMedia = new string[0];
            int Contador = 0;

            for (int i = 0; i < ListaPersonas.Length; i++)
            {
                if (ListaPersonas[i].Altura < Media)
                {
                    Array.Resize(ref NombrePersonasPorDebajoMedia, NombrePersonasPorDebajoMedia.Length + 1);
                    NombrePersonasPorDebajoMedia[Contador] = ListaPersonas[i].Nombre;
                    Contador++;
                }
            }
            Console.WriteLine("EL NOMBRE DE LAS PERSONAS POR DEBAJO DE LA MEDIA ES");
            return NombrePersonasPorDebajoMedia;
        }

        public static void MostrarPersonas(Personal.Personas[] ListaPersonas, string[] NombrePersonasPorEncimaMedia, string[] NombrePersonasPorDebajoMedia)// ESTA FUNCION MOSTRARA A LAS PERSONAS POR DEBAJO Y POR ENCIMA DE LA MEDIA
        {
            // Declaramos las variables
            int Contador = 0;
            Console.WriteLine("Las personas por encima de la media son: ");

            for (int i = 0; i < ListaPersonas.Length; i++)
            {
                Contador = 0;
                while (Contador < NombrePersonasPorEncimaMedia.Length)
                {
                    if (ListaPersonas[i].Nombre == NombrePersonasPorEncimaMedia[Contador])
                    {
                        Console.Write($" {ListaPersonas[i].Nombre} ");
                        Console.Write($" {ListaPersonas[i].Apellido} ");
                        Console.Write($" {ListaPersonas[i].Altura} ");
                        Contador = ListaPersonas.Length - 1;
                    }
                    else
                    {
                        Contador++;
                    }
                }
            }

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Las personas por debajo de la media son: ");

            for (int z = 0; z < ListaPersonas.Length; z++)
            {
                Contador= 0;
                while (Contador < NombrePersonasPorDebajoMedia.Length)
                {
                    if (ListaPersonas[z].Nombre == NombrePersonasPorDebajoMedia[Contador])
                    {
                        Console.Write($" {ListaPersonas[z].Nombre} ");
                        Console.Write($" {ListaPersonas[z].Apellido} ");
                        Console.Write($" {ListaPersonas[z].Altura} ");
                        Contador = ListaPersonas.Length - 1;
                    }
                    else
                    {
                        Contador++;
                    }
                }
                
            }
            Console.WriteLine("\n----------------------------------------------------");
        }

    }
}
