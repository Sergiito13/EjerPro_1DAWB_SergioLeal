using System;
namespace Ejercicio3
{
    class ProgramaPrincipal
    {
        public static void Main(string[] args)
        {
            // Declaramos las variables

            Alumnos[] Alumnos = Funciones.LeerDatosFichero();

            Funciones.MostrarContenidoEstructura(Alumnos);

            string[] NombreAlumnosSuspendidos = Funciones.CalcularAlumnosSuspendidos(Alumnos);

            Funciones.MostrarAlumnosSuspendidos3Eva(Alumnos,NombreAlumnosSuspendidos);
        }
    }
}