// <copyright file="CoachRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
// <summary>
// CoachRepository
// </summary>

namespace InfosAboutNBA.Repository
{
    using System.Linq;
    using InfosAboutNBA.Data;

    /// <summary>
    /// Class for Coaches wich represents ICoachRepository.
    /// </summary>
    public class CoachRepository : ICoachRepository
    {
        private NBA_DatabaseEntities entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachRepository"/> class.
        /// </summary>
        /// <param name="entities"> NBA_DataEntities, wich is automatically generated from database.</param>
        public CoachRepository(NBA_DatabaseEntities entities)
        {
            this.entities = entities;
        }

        /// <summary>
        /// Add one Coach item to the table Coaches.
        /// </summary>
        /// <param name="coach"> Coach object.</param>
        public void AddCoach(Coaches coach)
        {
            this.entities.Coaches.Add(coach);
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Removes the selected Coach item from the database.
        /// </summary>
        /// <param name="id"> id of the removable Coach item.</param>
        public void DeleteCoach(int id)
        {
            this.entities.Coaches.Remove(this.GetOne(id));
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Returns all Coach object from the table Coaches.
        /// </summary>
        /// <returns> All Coach object.</returns>
        public IQueryable<Coaches> GetAll()
        {
            return this.entities.Coaches;
        }

        /// <summary>
        /// Returns the selected Coach object from the table Coaches.
        /// </summary>
        /// <param name="id"> id of the selected Coach.</param>
        /// <returns> Selected Coach object.</returns>
        public Coaches GetOne(int id)
        {
            return this.entities.Coaches.Where(x => x.idCoaches == id).FirstOrDefault();
        }

        /// <summary>
        /// Modify the number of championships of the selected Coach.
        /// </summary>
        /// <param name="id"> id of the selected Coach.</param>
        /// <param name="newNumber"> New number of championships.</param>
        public void ModifyCoachNumberOfChampionships(int id, int newNumber)
        {
            var coach = this.GetOne(id);
            coach.NumberOfChampionships = newNumber;
            this.entities.SaveChanges();
        }

        /// <summary>
        /// Modify the win percentage of the selected Coach in the Season.
        /// </summary>
        /// <param name="id"> id of the selected Coach.</param>
        /// <param name="newPercentage"> New win percentage value.</param>
        public void ModifyCoachWinPercentageInSeason(int id, double newPercentage)
        {
            var coach = this.GetOne(id);
            coach.WinPercentage = newPercentage;
            this.entities.SaveChanges();
        }
    }
}
