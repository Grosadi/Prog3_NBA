using System;
using System.Collections.Generic;
using System.Linq;
using InfosAboutNBA.Data;
using InfosAboutNBA.Repository;

namespace InfosAboutNBA.Logic
{
    /// <summary>
    /// Logic class for Coaches wich represents ICoachLogic.
    /// </summary>
    public class CoachLogic : ICoachLogic
    {
        private ICoachRepository coachRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachLogic"/> class.
        /// Empty Constructor.
        /// </summary>
        public CoachLogic()
        {
            this.coachRepo = new CoachRepository(new NBA_DatabaseEntities());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoachLogic"/> class.
        /// The Constructor needs an ICoachRepository object.
        /// </summary>
        /// <param name="repository"> ICoachRepository object.</param>
        public CoachLogic(ICoachRepository repository)
        {
            this.coachRepo = repository;
        }

        /// <summary>
        /// Returns the selected Coach from the table Coaches.
        /// </summary>
        /// <param name="id"> id of the seleced Coach.</param>
        /// <returns> Selected Coach object.</returns>
        public Coaches GetOne(int id)
        {
            if (id <= 0 || id > this.coachRepo.GetAll().Count())
            {
                throw new CoachNotFoundException("Coach not found!");
            }
            else
            {
                return this.coachRepo.GetOne(id);
            }
        }

        /// <summary>
        /// Returns a List of all Coach from the table Coaches.
        /// </summary>
        /// <returns> List of Coaches.</returns>
        public List<Coaches> GetAll()
        {
            return this.coachRepo.GetAll().ToList();
        }

        /// <summary>
        /// Add new Coach item to the table Coaches.
        /// </summary>
        /// <param name="coach"> New Coach object.</param>
        public void Add(Coaches coach)
        {
            if (coach.idCoaches == this.coachRepo.GetOne(coach.idCoaches).idCoaches)
            {
                coach.idCoaches = this.coachRepo.GetAll().Count() + 1;
                throw new Exception("This index is already used!\t New index: " + coach.idCoaches);
            }
            else
            {
                this.coachRepo.AddCoach(coach);
            }
        }

        /// <summary>
        /// Removes the selected Coach from the database.
        /// </summary>
        /// <param name="id"> id of the removable Coach.</param>
        public void Delete(int id)
        {
            if (this.coachRepo.GetOne(id) == null)
            {
                throw new CoachNotFoundException("This Coach is already deleted or doesn't exist!");
            }
            else
            {
                this.coachRepo.DeleteCoach(id);
            }
        }

        /// <summary>
        /// Returns true, if the selected Coach ever been a champion.
        /// </summary>
        /// <param name="id"> id of the selected Coach.</param>
        /// <returns> True or False value.</returns>
        public bool Champion(int id)
        {
            if (this.coachRepo.GetOne(id) == null)
            {
                throw new CoachNotFoundException("This Coach is already deleted or doesn't exist!");
            }
            else
            {
                if (this.coachRepo.GetOne(id).NumberOfChampionships != 0)
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
        /// Modify the win percentage of the selected Coach int the Season.
        /// </summary>
        /// <param name="id"> id of the selected Coach.</param>
        /// <param name="newPercentage"> New win percentage value.</param>
        public void ModifyCoachWinPercentageInSeason(int id, double newPercentage)
        {
            if (this.coachRepo.GetOne(id) == null)
            {
                throw new CoachNotFoundException("This Coach is already deleted or doesn't exist!");
            }
            else if (newPercentage > 1 || newPercentage < 0)
            {
                throw new Exception("Invalid Percentage!");
            }
            else
            {
                this.coachRepo.ModifyCoachWinPercentageInSeason(id, newPercentage);
            }
        }

        /// <summary>
        /// Modify the number of championships of the selected Coach.
        /// </summary>
        /// <param name="id"> id of the selected Coach</param>
        /// <param name="newNumber"> New number of championships.</param>
        public void ModifyCoachNumberOfChampionships(int id, int newNumber)
        {
            if (this.coachRepo.GetOne(id) == null)
            {
                throw new CoachNotFoundException("This Coach is already deleted or doesn't exist!");
            }
            else if (newNumber < 0)
            {
                throw new Exception("Invalid number!");
            }
            else
            {
                this.coachRepo.ModifyCoachNumberOfChampionships(id, newNumber);
            }
        }

        /// <summary>
        /// Returns the Coach of the selected Team.
        /// </summary>
        /// <param name="idTeam"> id of the selected Team.</param>
        /// <returns> Coach object.</returns>
        public Coaches CoachOfTeam(int idTeam)
        {
            var coach = from x in this.coachRepo.GetAll()
                        where x.idTeams == idTeam
                        select x;
            return coach as Coaches;
        }
    }
}
