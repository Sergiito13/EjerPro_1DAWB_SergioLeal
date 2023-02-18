using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCopisteria
{
    public struct PersonasInscritas
    {
        public string nombres;
        public int copiaPagadas;
    }

    class CSIncrispcion
    {
        public static PersonasInscritas[] InscribirAlumnos()
        {
            // Declaramos las variables
            PersonasInscritas[] PersonasIncrs = new PersonasInscritas[0];
            string NombrePersonas = "", SalirOp1 = "FIN", SalirOp2 = "Fin", SalirOp3 = "fin";
            int BonoCopias = 0, ContadorPosiciones = 0, Contador = 1;
            bool Salir = false, SalirBono = false, NombreEsta = false;

            do
            {
                Console.WriteLine($"Dime un nombre para la persona {Contador} (Si quiere parar el programa escriba fin)");
                NombrePersonas = Console.ReadLine();
                if ((NombrePersonas == SalirOp1) || (NombrePersonas == SalirOp2) || (NombrePersonas == SalirOp3))
                {
                    Console.WriteLine("Ha decidido no introducir mas personas. ADIOS");
                    Salir = true;
                }
                else
                {
                    if (NombrePersonas.Length > 0)
                    {
                        NombreEsta = false;
                        for (int i = 0; i < PersonasIncrs.Length; i++)
                        {
                            if (PersonasIncrs[i].nombres == NombrePersonas)
                            {
                                Console.WriteLine("Error ! El nombre ya existe");
                                NombreEsta = true;
                            }
                        }
                        if (!NombreEsta)
                        {
                            Array.Resize(ref PersonasIncrs, PersonasIncrs.Length + 1);
                            PersonasIncrs[ContadorPosiciones].nombres = NombrePersonas;

                            SalirBono = false;
                            do
                            {
                                Console.WriteLine("¿Cuántas copias ha pagado?");
                                while (!int.TryParse(Console.ReadLine(), out BonoCopias))
                                {
                                    Console.WriteLine("Error ! El tipo de dato tiene que ser entero");
                                }

                                if (BonoCopias >= 10)
                                {
                                    PersonasIncrs[ContadorPosiciones].copiaPagadas = BonoCopias;
                                    ContadorPosiciones++;
                                    Contador++;
                                    SalirBono = true;
                                }
                                else
                                {
                                    Console.WriteLine("Error ! El numero minimo de copias a pagar es 10");
                                }
                            } while (!SalirBono);
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Error ! El nombre no puede estar vacio");
                    }
                }

            } while (!Salir);
            return PersonasIncrs;
        }

        public static void MostrarPersonasIncrs(PersonasInscritas[] personas)
        {
            Console.Clear();
            Console.WriteLine("Las personas Inscritas son: ");

            for (int i = 0; i < personas.Length; i++)
            {
                Console.Write($"\n {personas[i].nombres} ");

                Console.Write($" {personas[i].copiaPagadas} ");
            }
            Console.WriteLine("\n----------------------------------------");

        }
    }
}
