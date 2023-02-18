namespace EjercicioPAIRPROGRAMING
{
    class Personal
    {
        public struct Personas
        {
            public string Nombre;
            public string Apellido;
            public decimal Altura;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Declaramos las variables
            int NumeroPersonasSolicitadas = 0;
            Personal.Personas[] Personitas;
            decimal MediaAlturas = 0;


            NumeroPersonasSolicitadas = CSFunciones.SolicitarNumeroPersonas();

            Personitas = CSFunciones.LeerDatosMuestra(NumeroPersonasSolicitadas);

            CSFunciones.MostrarDatosMuestra(Personitas);

            MediaAlturas = CSAlturas.Media(Personitas);

            string[] NombrePersonasEncimaMedia = CSAlturas.PersonasPorEncimaMedia(Personitas, MediaAlturas);

            string[] NombrePersonasDebajoMedia = CSAlturas.PersonasPorDebajoMedia(Personitas, MediaAlturas);

            CSAlturas.MostrarPersonas(Personitas, NombrePersonasEncimaMedia, NombrePersonasDebajoMedia);
        }
    }
}
