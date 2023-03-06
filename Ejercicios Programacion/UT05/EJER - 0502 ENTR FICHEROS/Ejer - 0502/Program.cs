namespace EjerFicheros
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<mediaMunicipios> datosMunicipio = Utils.LeerDatosFichero();
            const string NOMBRE_FICHERO_LOGS = "..\\..\\..\\errores.log";

            if (!File.Exists(NOMBRE_FICHERO_LOGS))
            {
                Utils.EscribirDatosFicheroMedias(datosMunicipio);
                Utils.MostrarResultadoFicheroMediaPoblacion();
            }
            else
            {
                Utils.MostrarResultadoFicherologs();
            }
            
        }
    }
}
