// <copyright file="PlayerLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// PlayerLogic
// </summary>

namespace InfosAboutNba.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using InfosAboutNba.Data;
    using InfosAboutNba.Repository;

    /// <summary>
    /// Logic class for Players wich represents IPlayerLogic interface.
    /// </summary>
    public class PlayerLogic : IPlayerLogic
    {
        private IPlayerRepository playerRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerLogic"/> class.
        /// Empty Constructor.
        /// </summary>
        public PlayerLogic()
        {
            this.playerRepo = new PlayerRepository(new NBA_DatabaseEntities());

            // Generate basic value to Players.PointsInSeason & Players.Value
            foreach (var item in this.playerRepo.GetAll())
            {
                if (item.NumberOfPlayedSeason != 0)
                {
                    item.PointsInSeason = item.LifetimePoints / item.NumberOfPlayedSeason;
                }
                else
                {
                    item.PointsInSeason = (item.Age * item.Height) / 5;
                }

                item.PValue = (item.PointsInSeason * 100) + (item.NumberOfChampionships.Value * 10000);
            }

            foreach (var item in this.playerRepo.GetAll())
            {
                if (item.NumberOfPlayedSeason == 0)
                {
                    item.LifetimePoints = item.PointsInSeason;
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerLogic"/> class.
        /// The Constructor needs a IPlayerRepository object.
        /// </summary>
        /// <param name="repository"> IPlayerRepository object.</param>
        public PlayerLogic(IPlayerRepository repository)
        {
            this.playerRepo = repository;
        }

        /// <summary>
        /// Returns the selected Player object from table Players.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <returns> Selected Player.</returns>
        public Players GetOne(int id)
        {
            if (id <= 0 || id > this.playerRepo.GetAll().Count())
            {
                throw new IndexOutOfRangeException("Index is out of Range!");
            }
            else
            {
                return this.playerRepo.GetOne(id);
            }
        }

        /// <summary>
        /// Returns a List with the all Player item from table Players.
        /// </summary>
        /// <returns> List of Players.</returns>
        public List<Players> GetAll()
        {
            return this.playerRepo.GetAll().ToList();
        }

        /// <summary>
        /// Add new Player object to the table Players.
        /// </summary>
        /// <param name="item"> Player object.</param>
        public void Add(Players item)
        {
            if (item.idPlayers == this.playerRepo.GetOne(item.idPlayers).idPlayers)
            {
                item.idPlayers = this.playerRepo.GetAll().Count() + 1;
                throw new Exception("This index is already used!\t New index: " + item.idPlayers);
            }
            else
            {
                this.playerRepo.AddPlayer(item);
            }
        }

        /// <summary>
        /// Removes the selected Player from the database.
        /// </summary>
        /// <param name="id"> id of the removable Player.</param>
        public void Delete(int id)
        {
            if (this.playerRepo.GetOne(id) == null)
            {
                throw new Exception("This player is already deleted or doesn't exist!");
            }
            else
            {
                this.playerRepo.DeletePlayer(id);
            }
        }

        /// <summary>
        /// Returns true, if the selected Player ever been a champion.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <returns> True or False value.</returns>
        public bool Champion(int id)
        {
            if (this.playerRepo.GetOne(id) == null)
            {
                throw new Exception("Player not found!");
            }
            else
            {
                if (this.playerRepo.GetOne(id).NumberOfChampionships != 0)
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
        /// Modify the age of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newAge"> New age value.</param>
        public void ModifyPlayerAge(int id, int newAge)
        {
            if (this.playerRepo.GetOne(id) == null)
            {
                throw new Exception("Player not found!");
            }
            else if (newAge <= 0 || newAge > 99)
            {
                throw new Exception("Wrong age value!");
            }
            else
            {
                this.playerRepo.ModifyPlayerAge(id, newAge);
            }
        }

        /// <summary>
        /// Modify the height of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newHeigh"> New height value.</param>
        public void ModifyPlayerHeight(int id, int newHeigh)
        {
            if (this.playerRepo.GetOne(id) == null)
            {
                throw new Exception("Player not found!");
            }
            else if (newHeigh < 150 || newHeigh > 250)
            {
                throw new Exception("Invalid height value!");
            }
            else
            {
                this.playerRepo.ModifyPlayerHeight(id, newHeigh);
            }
        }

        /// <summary>
        /// Modify the weight of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newWeight"> New weight value.</param>
        public void ModifyPlayerWeight(int id, int newWeight)
        {
            if (this.playerRepo.GetOne(id) == null)
            {
                throw new Exception("Player not found!");
            }
            else if (newWeight < 60 || newWeight > 180)
            {
                throw new Exception("Invalid weight value!");
            }
            else
            {
                this.playerRepo.ModifyPlayerWeight(id, newWeight);
            }
        }

        /// <summary>
        /// Modify the points of the selected Player in the Season.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newPoints"> New point value.</param>
        public void ModifyPlayerPointsInSeason(int id, int newPoints)
        {
            if (this.playerRepo.GetOne(id) == null)
            {
                throw new Exception("Player not found!");
            }
            else if (newPoints < 0 || newPoints > 4000)
            {
                throw new Exception("Invalid points value!");
            }
            else
            {
                this.playerRepo.ModifyPlayerPointsInSeason(id, newPoints);
            }
        }

        /// <summary>
        /// Modify the number of championships of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newNumber"> New number of championships.</param>
        public void ModifyPlayerNumberOfChampionships(int id, int newNumber)
        {
            if (this.playerRepo.GetOne(id) == null)
            {
                throw new Exception("Player not found!");
            }
            else if (newNumber < 0)
            {
                throw new Exception("Invalid number!");
            }
            else
            {
                this.playerRepo.ModifyPlayerNumberOfChampionships(id, newNumber);
            }
        }

        /// <summary>
        /// Returns a List with all Players of the selected Team.
        /// </summary>
        /// <param name="idTeam"> id of the seleted Team.</param>
        /// <returns> List of Players.</returns>
        public List<Players> TeamRoster(int idTeam)
        {
            var roster = from x in this.playerRepo.GetAll()
                         where x.idTeams == idTeam
                         orderby x.PName ascending
                         select x;

            List<Players> list = roster.ToList();

            return list;
        }

        /// <summary>
        /// Returns the Value of the selected Team.
        /// Sum of the Players value in the selected Team.
        /// </summary>
        /// <param name="idTeam"> id of the selected Team.</param>
        /// <returns> Value of the selected Team.</returns>
        public int TeamValue(int idTeam)
        {
            var roster = this.TeamRoster(idTeam);
            int value = 0;
            foreach (var item in roster)
            {
                value += item.PValue.Value;
            }

            return value;
        }
    }
}
