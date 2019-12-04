// <copyright file="IPlayerRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// IPlayerRepository
// </summary>

namespace InfosAboutNba.Repository
{
    using InfosAboutNba.Data;

    /// <summary>
    /// Inteface of Players wich represents basic interface, IRepository.
    /// </summary>
    public interface IPlayerRepository : IRepository<Players>
    {
        /// <summary>
        /// Add one Player to the table Players.
        /// </summary>
        /// <param name="player"> Player object.</param>
        void AddPlayer(Players player);

        /// <summary>
        /// Returns one selected Player object.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <returns> One Player object.</returns>
        new Players GetOne(int id);

        /// <summary>
        /// Modify the age of the selected Player.
        /// </summary>
        /// <param name="id"> id of selected Player.</param>
        /// <param name="newAge"> New age value.</param>
        void ModifyPlayerAge(int id, int newAge);

        /// <summary>
        /// Modify the height of the selected Player.
        /// </summary>
        /// <param name="id"> id of selected Player.</param>
        /// <param name="newHeigh"> New height value.</param>
        void ModifyPlayerHeight(int id, int newHeigh);

        /// <summary>
        /// Modify the weight of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newWeight"> New weight value. </param>
        void ModifyPlayerWeight(int id, int newWeight);

        /// <summary>
        /// Modify the points of the selected Player in the Season.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newPoints"> New Point value.</param>
        void ModifyPlayerPointsInSeason(int id, int newPoints);

        /// <summary>
        /// Modify the number of championships of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Playar.</param>
        /// <param name="newNumber"> New number of championships.</param>
        void ModifyPlayerNumberOfChampionships(int id, int newNumber);

        /// <summary>
        /// Removes the selected Player from the database.
        /// </summary>
        /// <param name="id"> id of the removable Player.</param>
        void DeletePlayer(int id);
    }
}
