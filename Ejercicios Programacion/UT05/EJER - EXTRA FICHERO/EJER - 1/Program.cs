namespace ejer1
{
    class Program
    {
        public static void Main(string[] agrs)
        {
            // Declaramos las variables
            bool hola = true;

            int[] years = Utils.ReadFileAndSaveInArrayYear(hola);

            string[] nation = Utils.ReadFileAndSaveInArrayNation(hola);

            string nationChoose = Utils.ChooseNation(nation);

            int yearChoose = Utils.ChooseYear(years);

            Utils.showAllSelecteddata(yearChoose,nationChoose);
        }
    }
}
