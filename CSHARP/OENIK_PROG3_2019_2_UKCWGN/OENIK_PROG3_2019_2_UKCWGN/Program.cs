using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfosAboutNBA.Logic;

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
            TeamLogic team = new TeamLogic();
            PlayerLogic player = new PlayerLogic();
            CoachLogic coach = new CoachLogic();

            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Teams");
            Console.WriteLine("2) Players");
            Console.WriteLine("3) Coaches");
            Console.WriteLine("4) List Player and Coaches of a Team");
            Console.WriteLine("5) Modify a Team Roster");
            Console.WriteLine("6) Ranking Teams by win percentage");
            Console.WriteLine("7) Has this Team ever been a champion?");
            Console.WriteLine("8) Has this Player ever been a champion?");
            Console.WriteLine("9) Has this Coach ever been a champion?");
            Console.WriteLine("10) List of Teams and order by Value of Roster");
            Console.WriteLine("11) Get season standing from Web Application");
            Console.WriteLine("12) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("1) List Teams");
                    Console.WriteLine("2) Add Team");
                    Console.WriteLine("3) Modify Team");
                    Console.WriteLine("4) Remove Team");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            foreach (var item in team.GetAll())
                            {
                                Console.WriteLine(item.idTeams + "\t" + item.TName);
                            }

                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "2":
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "3":
                            Console.WriteLine("Ez a funkció még nem elérhető");
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "4":
                            Console.WriteLine("ID of removable team:");
                            team.Delete(int.Parse(Console.ReadLine()));
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                    }

                    return true;

                case "2":
                    Console.WriteLine("1) List Players");
                    Console.WriteLine("2) Add Player");
                    Console.WriteLine("3) Modify Player");
                    Console.WriteLine("4) Remove Player");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            foreach (var item in player.GetAll())
                            {
                                Console.WriteLine(item.idPlayers + "\t" + item.PName);
                            }

                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "2":
                            Console.WriteLine("Ez a funkció még nem elérhető");
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "3":
                            Console.WriteLine("Ez a funkció még nem elérhető");
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "4":
                            Console.WriteLine("ID of removable player:");
                            player.Delete(int.Parse(Console.ReadLine()));
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                    }

                    return true;

                case "3":
                    Console.WriteLine("1) List Coaches");
                    Console.WriteLine("2) Add Coach");
                    Console.WriteLine("3) Modify Coach");
                    Console.WriteLine("4) Remove Coach");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            foreach (var item in coach.GetAll())
                            {
                                Console.WriteLine(item.idCoaches + "\t" + item.CName);
                            }
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "2":
                            Console.WriteLine("Ez a funkció még nem elérhető");
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "3":
                            Console.WriteLine("Ez a funkció még nem elérhető");
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "4":
                            coach.Delete(int.Parse(Console.ReadLine()));
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                    }

                    return true;

                case "4":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "5":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "6":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "7":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "9":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "10":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "11":
                    Console.WriteLine("Ez a funkció még nem elérhető");
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "12":
                    return false;
                default:
                    return true;
            }
        }
    }
}