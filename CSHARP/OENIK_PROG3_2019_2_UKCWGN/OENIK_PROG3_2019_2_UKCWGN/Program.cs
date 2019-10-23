using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OENIK_PROG3_2019_2_UKCWGN
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) List Teams");
            Console.WriteLine("2) Add new Team");
            Console.WriteLine("3) Modify Team");
            Console.WriteLine("4) Delete Team");
            Console.WriteLine("5) List Players");
            Console.WriteLine("6) Add new Player");
            Console.WriteLine("7) Modify Player");
            Console.WriteLine("8) Delete Player");
            Console.WriteLine("10) List Coaches");
            Console.WriteLine("11) Add new Coach");
            Console.WriteLine("12) Modify Coach");
            Console.WriteLine("13) Delete Coach");
            Console.WriteLine("14) List Player and Coaches of a Team");
            Console.WriteLine("14) Modify a Team Roster");
            Console.WriteLine("15) Ranking Teams by win percentage");
            Console.WriteLine("16) Has this Team ever been a champion?");
            Console.WriteLine("17) Has this Player ever been a champion?");
            Console.WriteLine("18) Has this Coach ever been a champion?");
            Console.WriteLine("19) List of Teams and order by Value of Roster");
            Console.WriteLine("20) Get season standing from Web Application");
            Console.WriteLine("ESC) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "2":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "4":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "5":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "6":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "7":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "9":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "10":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "11":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "12":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "13":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "14":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "15":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "16":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "17":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "18":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "19":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "20":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("Press Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "21":
                    return false;
                default:
                    return true;
            }
        }
    }
}