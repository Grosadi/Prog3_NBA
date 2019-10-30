using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfosAboutNBA.Data;
using InfosAboutNBA.Repository;

namespace InfosAboutNBA.Logic
{
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
        /// <param name="id"> id of the selected Player</param>
        /// <param name="newHeigh"> New height value.</param>
        void ModifyPlayerHeight(int id, int newHeigh);

        /// <summary>
        /// Modify the weight of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player</param>
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
        /// <param name="id"> id of the selected Coach</param>
        /// <param name="newNumber"> New number of championships.</param>
        void ModifyCoachNumberOfChampionships(int id, int newNumber);
    }

    /// <summary>
    /// Logic class for Teams wich represents ITeamLogic interface.
    /// </summary>
    public class TeamLogic : ITeamLogic
    {
        private ITeamRepository teamRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLogic"/> class.
        /// Empty Constructor.
        /// </summary>
        public TeamLogic()
        {
            this.teamRepo = new TeamRepository(new NBA_DataEntities());
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamLogic"/> class.
        /// The Constructor needs a ITeamRepository object.
        /// </summary>
        /// <param name="repo"> ITeamRepository object</param>
        public TeamLogic(ITeamRepository repo)
        {
            this.teamRepo = repo;
        }

        /// <summary>
        /// Returns the selected Team from tables Teams.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <returns> Selected Team object.</returns>
        public Teams GetOne(int id)
        {
            return this.teamRepo.GetOne(id);
        }

        /// <summary>
        /// Returns a List with the all Team from the tables Teams.
        /// </summary>
        /// <returns> List of Teams.</returns>
        public List<Teams> GetAll()
        {
            return this.teamRepo.GetAll().ToList();
        }

        /// <summary>
        /// Add one Team object to the tables Teams.
        /// </summary>
        /// <param name="team"> A Team object.</param>
        public void Add(Teams team)
        {
            this.teamRepo.AddTeam(team);
        }

        /// <summary>
        /// Removes the selected Team from the database.
        /// </summary>
        /// <param name="id"> id of the removable Team.</param>
        public void Delete(int id)
        {
            this.teamRepo.DeleteTeam(id);
        }

        /// <summary>
        /// Modify the win percentage of the selected Team in the Season.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <param name="newPercentage"> New win percentage value.</param>
        public void ModifyTeamWinPercentageInSeason(int id, double newPercentage)
        {
            this.teamRepo.ModifyTeamWinPercentageInSeason(id, newPercentage);
        }

        /// <summary>
        /// Modify the number of championships of the selected Team.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <param name="newNumber"> New number of championships.</param>
        public void ModifyTeamNumberOfChampionships(int id, int newNumber)
        {
            this.teamRepo.ModifyTeamNumberOfChampionships(id, newNumber);
        }

        /// <summary>
        /// Returns true, if the selected Team ever been a champion.
        /// </summary>
        /// <param name="id"> id of the selected Team.</param>
        /// <returns> True or False value.</returns>
        public bool Champion(int id)
        {
            if (this.teamRepo.GetOne(id).NumberOfChampionships != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Ranks Teams by all time win percentage.
        /// </summary>
        public void RankingAllTime()
        {
            var ranking = from x in this.teamRepo.GetAll()
                          orderby x.WinPercentageSinceFounded descending
                          select x;
        }
    }

    public class PlayerLogic : IPlayerLogic
    {
        private IPlayerRepository playerRepo;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerLogic"/> class.
        /// Empty Constructor.
        /// </summary>
        public PlayerLogic()
        {
            this.playerRepo = new PlayerRepository(new NBA_DataEntities());
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
            return this.playerRepo.GetOne(id);
        }

        /// <summary>
        /// Returns a List with the all Player item from table Players
        /// </summary>
        /// <returns> List of Players.</returns>
        public List<Players> GetAll()
        {
            return this.playerRepo.GetAll().ToList();
        }

        /// <summary>
        /// Add new Player object to the table Players.
        /// </summary>
        /// <param name="player"> Player object.</param>
        public void Add(Players player)
        {
            this.playerRepo.AddPlayer(player);
        }

        /// <summary>
        /// Removes the selected Player from the database.
        /// </summary>
        /// <param name="id"> id of the removable Player.</param>
        public void Delete(int id)
        {
            this.playerRepo.DeletePlayer(id);
        }

        /// <summary>
        /// Returns true, if the selected Player ever been a champion.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <returns> True or False value.</returns>
        public bool Champion(int id)
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

        /// <summary>
        /// Modify the age of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newAge"> New age value.</param>
        public void ModifyPlayerAge(int id, int newAge)
        {
            this.playerRepo.ModifyPlayerAge(id, newAge);
        }

        /// <summary>
        /// Modify the height of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player</param>
        /// <param name="newHeigh"> New height value.</param>
        public void ModifyPlayerHeight(int id, int newHeigh)
        {
            this.playerRepo.ModifyPlayerHeight(id, newHeigh);
        }

        /// <summary>
        /// Modify the weight of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player</param>
        /// <param name="newWeight"> New weight value.</param>
        public void ModifyPlayerWeight(int id, int newWeight)
        {
            this.playerRepo.ModifyPlayerWeight(id, newWeight);
        }

        /// <summary>
        /// Modify the points of the selected Player in the Season.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newPoints"> New point value.</param>
        public void ModifyPlayerPointsInSeason(int id, int newPoints)
        {
            this.playerRepo.ModifyPlayerPointsInSeason(id, newPoints);
        }

        /// <summary>
        /// Modify the number of championships of the selected Player.
        /// </summary>
        /// <param name="id"> id of the selected Player.</param>
        /// <param name="newNumber"> New number of championships.</param>
        public void ModifyPlayerNumberOfChampionships(int id, int newNumber)
        {
            this.playerRepo.ModifyPlayerNumberOfChampionships(id, newNumber);
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
            this.coachRepo = new CoachRepository(new NBA_DataEntities());
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
            return this.coachRepo.GetOne(id);
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
            this.coachRepo.AddCoach(coach);
        }

        /// <summary>
        /// Removes the selected Coach from the database.
        /// </summary>
        /// <param name="id"> id of the removable Coach.</param>
        public void Delete(int id)
        {
            this.coachRepo.DeleteCoach(id);
        }

        /// <summary>
        /// Returns true, if the selected Coach ever been a champion.
        /// </summary>
        /// <param name="id"> id of the selected Coach.</param>
        /// <returns> True or False value.</returns>
        public bool Champion(int id)
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

        /// <summary>
        /// Modify the win percentage of the selected Coach int the Season.
        /// </summary>
        /// <param name="id"> id of the selected Coach.</param>
        /// <param name="newPercentage"> New win percentage value.</param>
        public void ModifyCoachWinPercentageInSeason(int id, double newPercentage)
        {
            this.coachRepo.ModifyCoachWinPercentageInSeason(id, newPercentage);
        }

        /// <summary>
        /// Modify the number of championships of the selected Coach.
        /// </summary>
        /// <param name="id"> id of the selected Coach</param>
        /// <param name="newNumber"> New number of championships.</param>
        public void ModifyCoachNumberOfChampionships(int id, int newNumber)
        {
            this.coachRepo.ModifyCoachNumberOfChampionships(id, newNumber);
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

    class LogicClasses
    {
    }
}
