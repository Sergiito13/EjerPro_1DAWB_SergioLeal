using UT0507;

static void Main(string[] agrs)
{
    int opcion = 0;
    bool noerror = true;
    if (Fichero.IniciarFichero())
    {
        do
        {
            Menu.VerMenu();
            opcion = Menu.LeerOpcion();
            Console.Write("\n");

            switch (opcion)
            {
                case 1: noerror = Fichero.EscribirFichero(); break;
                case 2: noerror = Fichero.EliminarLineaFichero(); break;
                case 3: noerror = Fichero.MostrarFichero(); break;
                case 4: noerror = Fichero.CrearFichero(); break;
                case 5: Console.Clear(); noerror = false; break;
            }

        } while (noerror);
    }
    Menu.Adios();
}
