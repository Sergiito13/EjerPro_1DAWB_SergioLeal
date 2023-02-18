using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EjercicioCopisteria
{
    public struct VentasRealizadas
    {
        public string ventaNombre;
        public int ventaNumCopias;
    }
    class CSTienda
    { 
        public static int[] SacarBonosPersonas(PersonasInscritas[] personas) // ESTA FUNCION SACARA LOS BONOS DE LAS PERSONAS INSCRITAS EN UN ARRAY DE ENTERO
        {
            // Declaramos las variables
            int[] BonosUsers = new int[personas.Length];

            for (int i = 0; i < personas.Length; i++)
            {
                BonosUsers[i] = personas[i].copiaPagadas;
            }
            return BonosUsers;

        } 

        public static VentasRealizadas[] RealizarNuevaVenta(VentasRealizadas[] ventas, PersonasInscritas[] Personas, int[] BonosUsers) // ESTA FUNCION REALIZARA UNA NUEVA VENTA
        {
            // Declaramos las variables
            string NombreElegidoVentas = "";
            int Contador = 0, NumeroCopias = 0, PosicionPersona = 0;
            bool Salir = false, NombreEsta = false;

            CSIncrispcion.MostrarPersonasIncrs(Personas);

            do
            {
                Console.WriteLine("\nDime un nombre de persona que exista");
                NombreElegidoVentas = Console.ReadLine();

                NombreEsta = false;
                for (int i = 0; i < Personas.Length; i++)
                {
                    if (Personas[i].nombres == NombreElegidoVentas)
                    {
                        NombreEsta = true;
                        PosicionPersona = i;
                    }
                }

                if (NombreEsta)
                {
                    Salir = true;
                }
                else
                {
                    Console.WriteLine("Error ! El nombre no existe");
                }

            } while (!Salir);

            Salir= false;

            do
            {
                Console.WriteLine("\nDime cuantas copias deseas hacer");
                while (!int.TryParse(Console.ReadLine(), out NumeroCopias))
                {
                    Console.WriteLine("Error! El dato introducido tiene que ser de tipo int");
                }

                if (NumeroCopias > 0)
                {
                    for (int i = 0; i < BonosUsers.Length; i++)
                    {
                        if (PosicionPersona == i)
                        {
                            if (BonosUsers[i] >= NumeroCopias)
                            {
                                Console.WriteLine("Correcto se ha realizado las copias");
                                BonosUsers[i] = BonosUsers[i] - NumeroCopias;
                                Array.Resize(ref ventas,ventas.Length+1);
                                Contador = ventas.Length-1;
                                ventas[Contador].ventaNombre = NombreElegidoVentas;
                                ventas[Contador].ventaNumCopias = NumeroCopias;
                                Salir= true;

                                Console.WriteLine($"Te quedan: {BonosUsers[i]} copias del bono");
                            }
                            else
                            {
                                Console.WriteLine("Error! No tienes fondos suficientes");
                                Salir= true;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error ! No puedes introducir datos negativos");
                }
   
            } while (!Salir);

            return ventas;
        } 

        public static void MostrarVentas(VentasRealizadas[] ventas, PersonasInscritas[] Personas, int[] BonosUsers) // ESTA FUNCION MOSTRARA LAS VENTAS
        {
            // Declaramos las variables
            int resta = 0, Contador = 0;
            decimal GananciasTotales = 0;
           

            Console.Clear();
            Console.WriteLine("\nESTADO DE LOS BON0S");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.Write("Nombre");
            Console.Write("\t\tCopias pagadas");
            Console.Write("\t\tCopias realizadas");
            Console.Write("\t\tCopias restantes");
            Console.Write("\t\tVentas realizadas");

            for (int i = 0; i < Personas.Length; i++)
            {
                Console.WriteLine($"\n{Personas[i].nombres}");
                Console.WriteLine($"\t\t{Personas[i].copiaPagadas}");

            }

            for (int z = 0; z < BonosUsers.Length; z++)
            {
                resta = Math.Abs(BonosUsers[z]-  Personas[z].copiaPagadas);
                Console.Write($"\n\t\t{resta}");
                Console.Write($"\t\t{BonosUsers[z]}");
            }

            for (int i = 0; i < Personas.Length; i++)
            {
                Contador = 0;
                for (int K = 0; K < ventas.Length; K++)
                {
                    if (Personas[i].nombres == ventas[K].ventaNombre)
                    {
                        Contador++;
                    }
                    if (K == ventas.Length-1)
                    {
                        Console.Write($"\n\t\t{Contador}");
                    }
                }
            }

            for (int j = 0; j < ventas.Length; j++) 
            {
                GananciasTotales = ventas[j].ventaNumCopias * 0.05m;
            }

            Console.WriteLine($"\nGanancias totales:{GananciasTotales}");


            Console.WriteLine("-------------------------------------------------------------------------------------");
        }
    }
}
