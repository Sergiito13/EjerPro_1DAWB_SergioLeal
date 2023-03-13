using System;
using System.Linq;

namespace ejer1
{
    class Utils
    {

        public const string ROUTE_TOURISM_FILE = "..\\..\\..\\Turismo.csv";
        public static bool TourismFileExists() // ESTA FUNCION COMPROBARA SI EXISTE O NO EL FICHERO Y DEVOLVERA UN BOOL LLAMADO fleExist
        {
            // Declaramos las variables
            bool fileExist = true;

            if (!File.Exists(ROUTE_TOURISM_FILE))
            {
                fileExist = false;
            }
            return fileExist;
        }

        public static int[] ReadFileAndSaveInArrayYear(bool fileExist) // ESTA FUNCION DEVOLVERA LOS AÑOS DEL FICHERO
        {
            // Declaramos las variables
            StreamReader SRead = null;
            string lineFile = "", yearSaved = "";
            string[] completeLine = new string[0];
            int[] yearTourismFile = new int[0];
            int fileYearCounter = 0, fileLineCounter = 1, verifiedYear = 0;



            if (fileExist)
            {
                try
                {
                    SRead = new StreamReader(ROUTE_TOURISM_FILE);

                    while (!SRead.EndOfStream)
                    {
                        lineFile = SRead.ReadLine();
                        completeLine = lineFile.Split(";");

                        if (fileLineCounter > 1)
                        {
                            // Sacaremos los años
                            yearSaved = completeLine[0];
                            if (int.TryParse(yearSaved, out verifiedYear))
                            {
                                if (!yearTourismFile.Contains(verifiedYear))
                                {
                                    Array.Resize(ref yearTourismFile, yearTourismFile.Length + 1);
                                    yearTourismFile[fileYearCounter] = verifiedYear;
                                    fileYearCounter++;
                                }
                            }
                        }
                        fileLineCounter++;
                    }
                    SRead.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine($"Error! No se ha encontrado el fichero: {ROUTE_TOURISM_FILE} ");
            }
            return yearTourismFile;

        }

        public static string[] ReadFileAndSaveInArrayNation(bool fileExist) // ESTA FUNCION DEVOLVERA LAS NACIONES DEL FICHERO
        {
            // Declaramos las variables
            StreamReader SRead = null;
            string[] completeLine = new string[0];
            string[] nationTourismFile = new string[0];
            string lineFile = "", nationSaved = "";
            int fileLineCounter = 1, fileYearCounter = 0;
            bool nationChecked = false;


            if (fileExist)
            {
                try
                {
                    SRead = new StreamReader(ROUTE_TOURISM_FILE);

                    while (!SRead.EndOfStream)
                    {
                        lineFile = SRead.ReadLine();
                        completeLine = lineFile.Split(";");

                        if (fileLineCounter > 1)
                        {
                            nationSaved = completeLine[1];


                            if (!nationChecked)
                            {
                                nationSaved = completeLine[2];

                                if (!(nationSaved == "TOTAL"))
                                {
                                    Array.Resize(ref nationTourismFile, nationTourismFile.Length + 1);
                                    nationTourismFile[fileYearCounter] = nationSaved;
                                    fileYearCounter++;
                                }
                                else
                                {
                                    nationChecked = true;
                                }
                            }
                        }
                        fileLineCounter++;
                    }
                    SRead.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine($"Error! No se ha encontrado el fichero: {ROUTE_TOURISM_FILE} ");
            }
            return nationTourismFile;
        }

        public static string ChooseNation(string[] nationTourismFile)
        {
            //Declaramos las variables
            string chosenNation = "";
            int option = 0, maximumNationNumber = 0;
            bool salir = false;

            Console.WriteLine("Elige el país o agrupación a seleccionar:");
            for (int i = 0; i < nationTourismFile.Length; i++)
            {
                Console.WriteLine($"{i+1} . {nationTourismFile[i]}");
            }

            do
            {
                Console.WriteLine("Elige una opcion:");
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("ERROR ! El dato tiene que ser numerico y entero");
                }

                maximumNationNumber = nationTourismFile.Length;

                if ((option >= 1) && (option <= maximumNationNumber))
                {
                    chosenNation = nationTourismFile[option - 1];
                    Console.Clear();
                    Console.WriteLine($"Haz seleccionado la nacion {chosenNation}");
                    salir = true;
                }
                else
                {
                    Console.WriteLine("El número seleccionado para la nacion no es válido");
                }

            } while (!salir);

            

            return chosenNation;
        } // ESTA FUNCION MOSTRARA LAS NACIONES Y NOS DARA LA OPCION DE ELEGIR LA NACION

        public static int ChooseYear(int[] yearTourismFile)
        {
            //Declaramos las variables
            int chosenYear = 0;
            int option = 0, maximumYearNumber = 0;
            bool salir = false;

            Console.WriteLine("Elige el país o agrupación a seleccionar:");
            for (int i = 0; i < yearTourismFile.Length; i++)
            {
                Console.WriteLine($"{i + 1} . {yearTourismFile[i]}");
            }

            do
            {
                Console.WriteLine("Elige una opcion:");
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("ERROR ! El dato tiene que ser numerico y entero");
                }

                maximumYearNumber = yearTourismFile.Length;

                if ((option >= 1) && (option <= maximumYearNumber))
                {
                    chosenYear = Convert.ToInt32(yearTourismFile[option - 1]);
                    Console.Clear();
                    Console.WriteLine($"Haz seleccionado el año {chosenYear}");
                    salir = true;
                }
                else
                {
                    Console.WriteLine("El número seleccionado para el año no es válido");
                }

            } while (!salir);



            return chosenYear;
        } // ESTA FUNCION MOSTRARA LOS AÑOS Y NOS DARA LA OPCION DE ELEGIR el AÑO

        public static void showAllSelecteddata(int yearChoose, string nationChoose) // ESTA FUNCION MOSTRARA TODOS LOS DATOS DEPENDIENDO DE LOS DATOS SELECCIONADOS ANTES
        {
            // Declaramos las variables
            StreamReader SRead = null;
            string[] months = { "Enero", "Febrero","Marzo", "Abril", "Mayo", "Junio", "Julio","Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            string lineFile = "";
            string[] completeLine = new string[0];
            int numberOfTheMonth = 0, sumHotels = 0, count = 0;

            try
            {
                SRead = new StreamReader(ROUTE_TOURISM_FILE);

                Console.WriteLine($"PAIS: {nationChoose}");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine($"AÑO: {yearChoose}");
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

                while (!SRead.EndOfStream)
                {
                    lineFile = SRead.ReadLine();
                    completeLine = lineFile.Split(";");

                    if ((completeLine[0] == Convert.ToString(yearChoose)) && (completeLine[2] == nationChoose))
                    {
                        numberOfTheMonth = Convert.ToInt32(completeLine[1]);

                        if (numberOfTheMonth <= 12)
                        {
                            sumHotels = Convert.ToInt32(completeLine[6]) + Convert.ToInt32(completeLine[7]);

                            Console.WriteLine($"Mes: {months[count]}          4 estrellas:   {completeLine[6]}          5 estrellas:   {completeLine[7]}                  Suma: {sumHotels}");
                            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                            count++;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }

    }
}
