// <copyright file="ICoachRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// ICoachRepository
// </summary>

namespace InfosAboutNBA.Repository
{
    using InfosAboutNBA.Data;

    /// <summary>
    /// Interface of Coaches wich represents basic interface, IRepository.
    /// </summary>
    public interface ICoachRepository : IRepository<Coaches>
    {
        /// <summary>
        /// Add one Coach item to the table Coaches.
        /// </summary>
        /// <param name="coach"> Coach object.</param>
        void AddCoach(Coaches coach);

        /// <summary>
        /// Returns the selected Coach object from the table Coaches.
        /// </summary>
        /// <param name="id"> id of the selected Coach.</param>
        /// <returns> Selected Coach object.</returns>
        new Coaches GetOne(int id);

        /// <summary>
        /// Modify the win percentage of the selected Coach in the Season.
        /// </summary>
        /// <param name="id"> id of the selected Coach.</param>
        /// <param name="newPercentage"> New win percentage value.</param>
        void ModifyCoachWinPercentageInSeason(int id, double newPercentage);

        /// <summary>
        /// Modify the number of championships of the selected Coach.
        /// </summary>
        /// <param name="id"> id of the selected Coach.</param>
        /// <param name="newNumber"> New number of championships.</param>
        void ModifyCoachNumberOfChampionships(int id, int newNumber);

        /// <summary>
        /// Removes the selected Coach item from the database.
        /// </summary>
        /// <param name="id"> id of the removable Coach item.</param>
        void DeleteCoach(int id);
    }
}
