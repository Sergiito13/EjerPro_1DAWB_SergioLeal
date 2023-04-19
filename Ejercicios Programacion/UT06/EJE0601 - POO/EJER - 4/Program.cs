using System;
namespace ejer4
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // Declaramos las variables
            List<Productos> products = new List<Productos>();
            bool salirAñadirCliente = false, salirPregunta = false;
            int ID = 0, contador = 0;
            string nombreProducto = "", preguntaSeguir = "";
            decimal precioProducto = 0;

            do
            {
                ID = Funciones.SacarIDProducto(products);
                contador = ID;

                nombreProducto = Funciones.PedirNombreProducto();
                precioProducto = Funciones.PedirPrecioProducto();

                ID++; contador++;
                /*Productos productoAux = new Productos(ID, nombreProducto, precioProducto);
                products.Add(productoAux);*/
                products.Add(new Productos(ID, nombreProducto, precioProducto));

                Console.WriteLine($"Se ha añadido correctamente el producto {contador}");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------");

                salirPregunta = false;
                do
                {
                    
                        Console.WriteLine("¿Quieres comprar otro producto? [si | no]");
                        preguntaSeguir = Console.ReadLine();

                        if (preguntaSeguir.Length > 0)
                        {
                            if ((preguntaSeguir == "si") || (preguntaSeguir == "Si") || (preguntaSeguir == "SI") || (preguntaSeguir == "sI"))
                            {
                                salirPregunta = true;
                            }
                            else if ((preguntaSeguir == "no") || (preguntaSeguir == "No") || (preguntaSeguir == "NO") || (preguntaSeguir == "nO"))
                            {
                                Console.WriteLine("Ha decidido no añadir más producto");
                                salirPregunta = true;
                                salirAñadirCliente = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error! La respuesta no puede estar vacia");
                        }
                } while (!salirPregunta);
            } while (!salirAñadirCliente);

            decimal NumeroArticulosGratis = contador/3;
            Math.Floor(NumeroArticulosGratis);


        }
    } 
}


