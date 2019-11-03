// <copyright file="ILogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// Interfaces for the Logic classes.
// </summary>
namespace InfosAboutNBA.Logic
{
    using System.Collections.Generic;
    using InfosAboutNBA.Data;

    /// <summary>
    /// Basic interface of the Logic classes.
    /// </summary>
    /// <typeparam name="T"> T is a class.</typeparam>
    public interface ILogic<T>
        where T : class
    {
        /// <summary>
        /// Returns the selected T type object.
        /// </summary>
        /// <param name="id"> id of the returnable object.</param>
        /// <returns> Selected object.</returns>
        T GetOne(int id);

        /// <summary>
        /// Returns a List whit the all T type object.
        /// </summary>
        /// <returns> T tpye List.</returns>
        List<T> GetAll();

        /// <summary>
        /// Add one T type item to the database.
        /// </summary>
        /// <param name="item"> T type object.</param>
        void Add(T item);

        /// <summary>
        /// Removes the selected T type object from the database.
        /// </summary>
        /// <param name="id"> id of the removable T type object.</param>
        void Delete(int id);

        /// <summary>
        /// Returns true, if the selected object was ever been a champion.
        /// </summary>
        /// <param name="id"> id of the selected object.</param>
        /// <returns> True or false value.</returns>
        bool Champion(int id);
    }

    /// <summary>
    /// Interface for Teams wich represents basic interface, ILogic.
    /// </summary>
    public interface ITeamLogic : ILogic<Teams>
    {
        /// <summary>
        /// Modify the win percentage of the selected Team in the Season.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <param name="newPercentage"> New win percentage value.</param>
        void ModifyTeamWinPercentageInSeason(int id, double newPercentage);

        /// <summary>
        /// Modify the number of championships of the selected Team.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <param name="newNumber"> New number of championships.</param>
        void ModifyTeamNumberOfChampionships(int id, int newNumber);
    }

    /// <summary>
    /// Interface for Players wich represents basic interface, ILogic.
    /// </summary>
    public interface IPlayerLogic : ILogic<Players>
    {
        /// <summary>
        /// Modify the age of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newAge"> New age value.</param>
        void ModifyPlayerAge(int id, int newAge);

        /// <summary>
        /// Modify the height of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newHeigh"> New height value.</param>
        void ModifyPlayerHeight(int id, int newHeigh);

        /// <summary>
        /// Modify the weight of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newWeight"> New weight value.</param>
        void ModifyPlayerWeight(int id, int newWeight);

        /// <summary>
        /// Modify the points of the selected Player in the Season.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newPoints"> New point value.</param>
        void ModifyPlayerPointsInSeason(int id, int newPoints);

        /// <summary>
        /// Modify the number of championships of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newNumber"> New number of championships.</param>
        void ModifyPlayerNumberOfChampionships(int id, int newNumber);
    }

    /// <summary>
    /// Interface for Coaches wich represents basic interface, ILogic.
    /// </summary>
    public interface ICoachLogic : ILogic<Coaches>
    {
        /// <summary>
        /// Modify the win percentage of the selected Coach int the Season.
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
    }
}
