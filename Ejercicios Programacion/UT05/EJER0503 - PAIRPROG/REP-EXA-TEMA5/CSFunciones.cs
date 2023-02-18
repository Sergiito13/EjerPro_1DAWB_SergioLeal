namespace EjercicioPAIRPROGRAMING
{
    class CSFunciones
    {

        public static int SolicitarNumeroPersonas() // ESTA FUNCION SOLICITARA UN NUMERO INICIAL DE PERSONAS
        {
            // Declaramos las variables
            int NumeroPersonas = 0;
            bool Correcto = false;

            do
            {
                Console.WriteLine("Dime el numero de personas que quieres ingresar");
                while (!int.TryParse(Console.ReadLine(), out NumeroPersonas))
                {
                    Console.WriteLine("Error! El tipo de dato tiene que ser entero");
                }
                if (NumeroPersonas > 2)
                {
                    Correcto = true;
                }
                else
                {
                    Console.WriteLine("Error ! El número no puede ser negativo ni menor a 2");
                }

            } while (!Correcto);// Repetimos el bucle hasta que el dato introducido sea tipo int y mayor a 2

            return NumeroPersonas; // devolvemos el dato

        }

        public static Personal.Personas[] LeerDatosMuestra(int personasMuestras)// ESTA FUNCION PEDIRA LOS NOMBRE,APELLIDOS Y LA ALTURA
        {
            // Declaramos las variables
            String nombrePersona = "", apellidoPersona;
            decimal alturaPersonas = 0;
            bool Correcto = false;
            int Contador = 0;

            Personal.Personas[] Personitas = new Personal.Personas[0];

            for (int i = 0; i < personasMuestras; i++)
            {
                Correcto = false;
                do
                {
                    Console.WriteLine($"Dime el nombre de la persona {i + 1} ");
                    nombrePersona = Console.ReadLine();

                    if (nombrePersona.Length > 0)
                    {
                        Array.Resize(ref Personitas, Personitas.Length + 1);
                        Personitas[Contador].Nombre = nombrePersona;
                        Correcto = true;
                    }
                    else
                    {
                        Console.WriteLine("Error! El nombre no puede estar vacia");
                    }

                } while (!Correcto);

                Correcto = false;
                do
                {
                    Console.WriteLine($"Dime el apellido de la persona {i + 1} ");
                    apellidoPersona = Console.ReadLine();

                    if (apellidoPersona.Length > 0)
                    {
                        Personitas[Contador].Apellido = apellidoPersona;
                        Correcto = true;
                    }
                    else
                    {
                        Console.WriteLine("Error! El apellido no puede estar vacia");
                    }

                } while (!Correcto);

                Correcto = false;
                do
                {
                    Console.WriteLine($"Dime la altura de la persona {i + 1} ");
                    while (!decimal.TryParse(Console.ReadLine(), out alturaPersonas))
                    {
                        Console.WriteLine("Error ! El tipo de dato tiene que ser numérico");
                    }

                    alturaPersonas = Math.Round(alturaPersonas, 2);

                    if ((alturaPersonas > 0) && (alturaPersonas < 3))
                    {
                        Personitas[Contador].Altura = alturaPersonas;
                        Correcto = true;
                        Contador++;

                    }
                    else
                    {
                        Console.WriteLine("Error! la altura no puede ser negativa ni mayor a 3 metros");
                    }
                } while (!Correcto);
            }

            return Personitas;
        }

        public static void MostrarDatosMuestra(Personal.Personas[] ListaPersonas) // ESTA FUNCION MOSTRARA LOS DATOS ALMACENADOS EN LA ESTRUCTURA
        {
            // Declaramos las variables
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Los datos son:");

            for (int i = 0; i < ListaPersonas.Length; i++)
            {
                Console.Write($"{ListaPersonas[i].Nombre} ");
                Console.Write($" {ListaPersonas[i].Apellido} ");
                Console.Write($" {ListaPersonas[i].Altura} metros");
            }
            Console.WriteLine("\n--------------------------------");
        }


    }
}
