// <copyright file="TeamLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// TeamLogic
// </summary>

namespace InfosAboutNba.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using InfosAboutNba.Data;
    using InfosAboutNba.Repository;

    /// <summary>
    /// Logic class for Teams wich represents ITeamLogic interface.
    /// </summary>
    public class TeamLogic : ITeamLogic
    {
        private ITeamRepository teamRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLogic"/> class.
        /// Empty Constructor.
        /// </summary>
        public TeamLogic()
        {
            this.teamRepo = new TeamRepository(new NBA_DatabaseEntities());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLogic"/> class.
        /// The Constructor needs a ITeamRepository object.
        /// </summary>
        /// <param name="repo"> ITeamRepository object.</param>
        public TeamLogic(ITeamRepository repo)
        {
            this.teamRepo = repo;
        }

        /// <summary>
        /// Returns the selected Team from tables Teams.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <returns> Selected Team object.</returns>
        public Teams GetOne(int id)
        {
            if (id <= 0 || id > this.teamRepo.GetAll().Count())
            {
                throw new IndexOutOfRangeException("Index is out of Range!");
            }
            else
            {
                return this.teamRepo.GetOne(id);
            }
        }

        /// <summary>
        /// Returns a List with the all Team from the tables Teams.
        /// </summary>
        /// <returns> List of Teams.</returns>
        public List<Teams> GetAll()
        {
            return this.teamRepo.GetAll().ToList();
        }

        /// <summary>
        /// Add one Team object to the tables Teams.
        /// </summary>
        /// <param name="item"> A Team object.</param>
        public void Add(Teams item)
        {
            if (item.idTeams == this.teamRepo.GetOne(item.idTeams).idTeams)
            {
                item.idTeams = this.teamRepo.GetAll().Count() + 1;
                throw new Exception("This index is already used!\t New index: " + item.idTeams);
            }
            else
            {
                this.teamRepo.AddTeam(item);
            }
        }

        /// <summary>
        /// Removes the selected Team from the database.
        /// </summary>
        /// <param name="id"> id of the removable Team.</param>
        public void Delete(int id)
        {
            if (this.teamRepo.GetOne(id) == null)
            {
                throw new Exception("This team is already deleted or doesn't exist!");
            }
            else
            {
                this.teamRepo.DeleteTeam(id);
            }
        }

        /// <summary>
        /// Modify the win percentage of the selected Team in the Season.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <param name="newPercentage"> New win percentage value.</param>
        public void ModifyTeamWinPercentageInSeason(int id, double newPercentage)
        {
            if (this.teamRepo.GetOne(id) == null)
            {
                throw new Exception("Team not found!");
            }
            else if (newPercentage > 1 || newPercentage < 0)
            {
                throw new Exception("Win Percentage should be between 0-1!");
            }
            else
            {
                this.teamRepo.ModifyTeamWinPercentageInSeason(id, newPercentage);
            }
        }

        /// <summary>
        /// Modify the number of championships of the selected Team.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <param name="newNumber"> New number of championships.</param>
        public void ModifyTeamNumberOfChampionships(int id, int newNumber)
        {
            if (this.teamRepo.GetOne(id) == null)
            {
                throw new Exception("Team not found!");
            }
            else if (newNumber < 0)
            {
                throw new Exception("Invalid number!");
            }
            else
            {
                this.teamRepo.ModifyTeamNumberOfChampionships(id, newNumber);
            }
        }

        /// <summary>
        /// Returns true, if the selected Team ever been a champion.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <returns> True or False value.</returns>
        public bool Champion(int id)
        {
            if (this.teamRepo.GetOne(id) == null)
            {
                throw new Exception("Team not found!");
            }
            else
            {
                if (this.teamRepo.GetOne(id).NumberOfChampionships != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Rank of teams by all time win percentage.
        /// </summary>
        /// <returns> Ordered list. </returns>
        public List<Teams> RankingAllTime()
        {
            var ranking = from x in this.teamRepo.GetAll()
                          orderby x.WinPercentageSinceFounded descending
                          select x;

            return ranking.ToList();
        }
    }
}
