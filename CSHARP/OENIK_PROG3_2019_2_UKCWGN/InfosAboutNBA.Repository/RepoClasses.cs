using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfosAboutNBA.Data;

namespace InfosAboutNBA.Repository
{
    /// <summary>
    /// Basic Interface.
    /// </summary>
    /// <typeparam name="T">Where T is a class.</typeparam>
    public interface IRepository<T>
        where T : class
    {
        /// <summary>
        /// Returns one item from the database.
        /// </summary>
        /// <param name="id"> id of a T type item from database.</param>
        /// <returns> T type item.</returns>
        T GetOne(int id);

        /// <summary>
        /// Returns all elements from the database.
        /// </summary>
        /// <returns> All T type item.</returns>
        IQueryable<T> GetAll();
    }

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
        /// <param name="id"> id of the selected Coach</param>
        /// <param name="newNumber"> New number of championships.</param>
        void ModifyCoachNumberOfChampionships(int id, int newNumber);

        /// <summary>
        /// Removes the selected Coach item from the database.
        /// </summary>
        /// <param name="id"> id of the removable Coach item.</param>
        void DeleteCoach(int id);
    }

    /// <summary>
    /// Class for Coaches wich represents ICoachRepository
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
        /// <param name="id"> id of the selected Coach</param>
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
