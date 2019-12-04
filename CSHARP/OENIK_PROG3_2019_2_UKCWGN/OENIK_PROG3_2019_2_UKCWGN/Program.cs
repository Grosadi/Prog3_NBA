// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// Main Program.
// </summary>

namespace OENIK_PROG3_2019_2_UKCWGN
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using InfosAboutNba.Logic;

    /// <summary>
    /// Main Program.
    /// </summary>
    internal class Program
    {
        private static void Main()
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
            Console.WriteLine("5) Ranking Teams by win percentage");
            Console.WriteLine("6) Has this Team ever been a champion?");
            Console.WriteLine("7) Has this Player ever been a champion?");
            Console.WriteLine("8) Has this Coach ever been a champion?");
            Console.WriteLine("9) Total value of a Team");
            Console.WriteLine("10) Get season standing from Web Application");
            Console.WriteLine("11) Exit");
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
                                Console.WriteLine(item.idTeams + "\t" + item.HomeTown + " " + item.TName);
                            }

                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "2":
                            Console.WriteLine("Name of Team:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Hometown:");
                            string city = Console.ReadLine();
                            team.Add(new InfosAboutNba.Data.Teams() { TName = name, HomeTown = city });
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "3":
                            Console.WriteLine("ID of team:");
                            int idt = int.Parse(Console.ReadLine());
                            Console.WriteLine("New number of championships:");
                            int newNum = int.Parse(Console.ReadLine());
                            team.ModifyTeamNumberOfChampionships(idt, newNum);
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
                            Console.WriteLine("Player name");
                            string name = Console.ReadLine();
                            player.Add(new InfosAboutNba.Data.Players() { PName = name });
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "3":
                            Console.WriteLine("ID of Player:");
                            int idp = int.Parse(Console.ReadLine());
                            Console.WriteLine("New age value:");
                            int age = int.Parse(Console.ReadLine());
                            player.ModifyPlayerAge(idp, age);
                            Console.WriteLine("New height value:");
                            int height = int.Parse(Console.ReadLine());
                            player.ModifyPlayerHeight(idp, height);
                            Console.WriteLine("New number of championships:");
                            int num = int.Parse(Console.ReadLine());
                            player.ModifyPlayerNumberOfChampionships(idp, num);
                            Console.WriteLine("New points in season:");
                            int points = int.Parse(Console.ReadLine());
                            player.ModifyPlayerPointsInSeason(idp, points);
                            Console.WriteLine("New weight value:");
                            int weight = int.Parse(Console.ReadLine());
                            player.ModifyPlayerWeight(idp, weight);
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
                            Console.WriteLine("Name of Coach:");
                            string name = Console.ReadLine();
                            coach.Add(new InfosAboutNba.Data.Coaches() { CName = name });
                            Console.WriteLine("\nPress Enter to get back to the MENU");
                            Console.ReadLine();
                            return true;
                        case "3":
                            Console.WriteLine("ID of Coach:");
                            int idc = int.Parse(Console.ReadLine());
                            Console.WriteLine("New number of championships:");
                            int num = int.Parse(Console.ReadLine());
                            coach.ModifyCoachNumberOfChampionships(idc, num);
                            Console.WriteLine("New win percentage in season: (0.xy)");
                            double percentage = double.Parse(Console.ReadLine());
                            coach.ModifyCoachWinPercentageInSeason(idc, percentage);
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
                    Console.WriteLine("ID of Team:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Coach: " + coach.CoachOfTeam(id));
                    Console.WriteLine("Players:");
                    foreach (var item in player.TeamRoster(id))
                    {
                        Console.WriteLine(item.PName);
                    }

                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "5":
                    foreach (var item in team.RankingAllTime())
                    {
                        Console.WriteLine(item.TName + " " + item.WinPercentageSinceFounded);
                    }

                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "6":
                    Console.WriteLine("ID of team:");
                    int idT = int.Parse(Console.ReadLine());
                    Console.WriteLine(team.Champion(idT));
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "7":
                    Console.WriteLine("ID of player:");
                    int idP = int.Parse(Console.ReadLine());
                    Console.WriteLine(player.Champion(idP));
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "8":
                    Console.WriteLine("ID of Coach");
                    int idC = int.Parse(Console.ReadLine());
                    Console.WriteLine(coach.Champion(idC));
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "9":
                    Console.WriteLine("ID of team:");
                    int idV = int.Parse(Console.ReadLine());
                    Console.WriteLine(team.GetOne(idV).TName + " " + player.TeamValue(idV) + "$");
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "10":
                    Console.WriteLine("\nPress Enter to get back to the MENU");
                    Console.ReadLine();
                    return true;
                case "11":
                    return false;
                default:
                    return true;
            }
        }
    }
}