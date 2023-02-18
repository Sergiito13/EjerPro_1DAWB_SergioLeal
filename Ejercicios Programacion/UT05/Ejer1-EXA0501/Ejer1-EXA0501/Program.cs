using System;
namespace EjercicioCopisteria
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // Declaramos las variables
            // VentasRealizadas[] ventas = new VentasRealizadas[0];
            PersonasInscritas[] PersonasIncrs = CSIncrispcion.InscribirAlumnos();
            VentasRealizadas[] ventas = new VentasRealizadas[0];
            CSIncrispcion.MostrarPersonasIncrs(PersonasIncrs);

            Menu.OpcionesMenu(PersonasIncrs,ventas);
        }
    }
}