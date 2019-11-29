// <copyright file="TeamRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// TeamRepository
// </summary>

namespace InfosAboutNBA.Repository
{
    using System.Linq;
    using InfosAboutNBA.Data;

    /// <summary>
    /// Class for the Teams wich represents ITeamRepository interface.
    /// </summary>
    public class TeamRepository : ITeamRepository
    {
        private NBA_DatabaseEntities entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamRepository"/> class TeamRepository.
        /// </summary>
        /// <param name="entities"> NBA_DataEntities, wich is automatically generated from databse.</param>
        public TeamRepository(NBA_DatabaseEntities entities)
        {
            this.entities = entities;
        }

        /// <summary>
        /// Add new Team object to the table Teams.
        /// </summary>
        /// <param name="team"> Team object.</param>
        public void AddTeam(Teams team)
        {
            this.entities.Teams.Add(team);
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Remove a Team object from the database.
        /// </summary>
        /// <param name="id"> id of the removable Team.</param>
        public void DeleteTeam(int id)
        {
            this.entities.Teams.Remove(this.GetOne(id));
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Returns all Team object from the table Teams.
        /// </summary>
        /// <returns> All Team object.</returns>
        public IQueryable<Teams> GetAll()
        {
            return this.entities.Teams;
        }

        /// <summary>
        /// Returns one Team object from the table Teams.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <returns> Selected Team object.</returns>
        public Teams GetOne(int id)
        {
            return this.entities.Teams.Where(x => x.idTeams == id).FirstOrDefault();
        }

        /// <summary>
        /// Modify the number of Championships of the selected Team.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <param name="newNumber"> New number of Championships.</param>
        public void ModifyTeamNumberOfChampionships(int id, int newNumber)
        {
            var team = this.GetOne(id);
            team.NumberOfChampionships = newNumber;
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Modify the win percentage of the selected Team in the Season.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <param name="newPercentage"> New win percentage.</param>
        public void ModifyTeamWinPercentageInSeason(int id, double newPercentage)
        {
            var team = this.GetOne(id);
            team.WinPercentageInSeason = newPercentage;
            this.entities.SaveChanges();
        }
    }
}
