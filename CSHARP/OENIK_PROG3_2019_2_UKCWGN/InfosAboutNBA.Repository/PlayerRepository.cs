// <copyright file="PlayerRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// PlayerRepository
// </summary>

namespace InfosAboutNba.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using InfosAboutNba.Data;

    /// <summary>
    /// Class for Players wich represents IPlayerRepository.
    /// </summary>
    public class PlayerRepository : IPlayerRepository
    {
        private NBA_DatabaseEntities entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerRepository"/> class.
        /// </summary>
        /// <param name="entities"> NBA_DataEntites, wich is automatically generated from database.</param>
        public PlayerRepository(NBA_DatabaseEntities entities)
        {
            this.entities = entities;
        }

        /// <summary>
        /// Add one Player to the table Players.
        /// </summary>
        /// <param name="player"> Player object.</param>
        public void AddPlayer(Players player)
        {
            this.entities.Players.Add(player);
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Removes the selected Player from the database.
        /// </summary>
        /// <param name="id"> id of the removable Player.</param>
        public void DeletePlayer(int id)
        {
            this.entities.Players.Remove(this.GetOne(id));
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Returns all Player object from table Players.
        /// </summary>
        /// <returns> All Player object.</returns>
        public IQueryable<Players> GetAll()
        {
            return this.entities.Players;
        }

        /// <summary>
        /// Returns the selected Player item from table Players.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <returns> Selected Player item.</returns>
        public Players GetOne(int id)
        {
            return this.entities.Players.Where(x => x.idPlayers == id).FirstOrDefault();
        }

        /// <summary>
        /// Modify the age of the selected Player.
        /// </summary>
        /// <param name="id"> id of selected Player.</param>
        /// <param name="newAge"> New age value.</param>
        public void ModifyPlayerAge(int id, int newAge)
        {
            var player = this.GetOne(id);
            player.Age = newAge;
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Modify the height of the selected Player.
        /// </summary>
        /// <param name="id"> id of selected Player.</param>
        /// <param name="newHeigh"> New height value.</param>
        public void ModifyPlayerHeight(int id, int newHeigh)
        {
            var player = this.GetOne(id);
            player.Height = newHeigh;
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Modify the number of championships of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Playar.</param>
        /// <param name="newNumber"> New number of championships.</param>
        public void ModifyPlayerNumberOfChampionships(int id, int newNumber)
        {
            var player = this.GetOne(id);
            player.NumberOfChampionships = newNumber;
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Modify the points of the selected Player in the Season.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newPoints"> New Point value.</param>
        public void ModifyPlayerPointsInSeason(int id, int newPoints)
        {
            var player = this.GetOne(id);
            player.PointsInSeason = newPoints;
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Modify the weight of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newWeight"> New weight value. </param>
        public void ModifyPlayerWeight(int id, int newWeight)
        {
            var player = this.GetOne(id);
            player.PWeight = newWeight;
            this.entities.SaveChanges();
        }
    }
}
