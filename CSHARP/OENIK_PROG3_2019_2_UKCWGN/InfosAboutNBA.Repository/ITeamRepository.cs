// <copyright file="ITeamRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// ITeamRepository
// </summary>

namespace InfosAboutNba.Repository
{
    using InfosAboutNba.Data;

    /// <summary>
    /// Interface for Teams.
    /// </summary>
    public interface ITeamRepository : IRepository<Teams>
    {
        /// <summary>
        /// Add one Teams item to the table Teams.
        /// </summary>
        /// <param name="team"> Teams type item.</param>
        void AddTeam(Teams team);

        /// <summary>
        /// Returns one Team from table Teams.
        /// </summary>
        /// <param name="id"> id of a Team.</param>
        /// <returns> one Team type item.</returns>
        new Teams GetOne(int id);

        /// <summary>
        /// Modify win percentage of a team in the season.
        /// </summary>
        /// <param name="id"> id of a Team.</param>
        /// <param name="newPercentage"> The new win percentage of the Team.</param>
        void ModifyTeamWinPercentageInSeason(int id, double newPercentage);

        /// <summary>
        /// Modify the number of championships of a team.
        /// </summary>
        /// <param name="id"> id of a Team.</param>
        /// <param name="newNumber"> The nw number of championships.</param>
        void ModifyTeamNumberOfChampionships(int id, int newNumber);

        /// <summary>
        /// Remove a Team from the Database.
        /// </summary>
        /// <param name="id"> id of a Team.</param>
        void DeleteTeam(int id);
    }
}
