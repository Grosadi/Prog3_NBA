using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfosAboutNBA.Data;
using InfosAboutNBA.Repository;

namespace InfosAboutNBA.Logic
{
    public interface ILogic<T>
        where T : class
    {
        T GetOne(int id);

        List<T> GetAll();

        void Add(T item);

        void Delete(int id);

        bool Champion(int id);
    }

    public interface ITeamLogic : ILogic<Teams>
    {
        void ModifyTeamWinPercentageInSeason(int id, double newPercentage);

        void ModifyTeamNumberOfChampionships(int id, int newNumber);
    }

    public interface IPlayerLogic : ILogic<Players>
    {
        void ModifyPlayerAge(int id, int newAge);

        void ModifyPlayerHeight(int id, int newHeigh);

        void ModifyPlayerWeight(int id, int newWeight);

        void ModifyPlayerPointsInSeason(int id, int newPoints);

        void ModifyPlayerNumberOfChampionships(int id, int newNumber);
    }

    public interface ICoachLogic : ILogic<Coaches>
    {
        void ModifyCoachWinPercentageInSeason(int id, double newPercentage);

        void ModifyCoachNumberOfChampionships(int id, int newNumber);
    }

    public class TeamLogic : ITeamLogic
    {
        private ITeamRepository teamRepo;

        public TeamLogic()
        {
            this.teamRepo = new TeamRepository(new NBA_DataEntities());
        }

        public TeamLogic(ITeamRepository repo)
        {
            this.teamRepo = repo;
        }

        public Teams GetOne(int id)
        {
            return teamRepo.GetOne(id);
        }

        public List<Teams> GetAll()
        {
            return teamRepo.GetAll().ToList();
        }

        public void Add(Teams team)
        {
            teamRepo.AddTeam(team);
        }

        public void Delete(int id)
        {
            teamRepo.DeleteTeam(id);
        }

        public void ModifyTeamWinPercentageInSeason(int id, double newPercentage)
        {
            teamRepo.ModifyTeamWinPercentageInSeason(id, newPercentage);
        }

        public void ModifyTeamNumberOfChampionships(int id, int newNumber)
        {
            teamRepo.ModifyTeamNumberOfChampionships(id, newNumber);
        }

        public bool Champion(int id)
        {
            if (teamRepo.GetOne(id).NumberOfChampionships != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RankingAllTime()
        {
            var ranking = from x in teamRepo.GetAll()
                          orderby x.WinPercentageSinceFounded descending
                          select x;
        }
    }

    public class PlayerLogic : IPlayerLogic
    {
        private IPlayerRepository playerRepo;

        public PlayerLogic()
        {
            this.playerRepo = new PlayerRepository(new NBA_DataEntities());
        }

        public PlayerLogic(IPlayerRepository repository)
        {
            this.playerRepo = repository;
        }

        public Players GetOne(int id)
        {
            return playerRepo.GetOne(id);
        }

        public List<Players> GetAll()
        {
            return playerRepo.GetAll().ToList();
        }

        public void Add(Players player)
        {
            playerRepo.AddPlayer(player);
        }

        public void Delete(int id)
        {
            playerRepo.DeletePlayer(id);
        }

        public bool Champion(int id)
        {
            if (playerRepo.GetOne(id).NumberOfChampionships != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ModifyPlayerAge(int id, int newAge)
        {
            playerRepo.ModifyPlayerAge(id, newAge);
        }

        public void ModifyPlayerHeight(int id, int newHeigh)
        {
            playerRepo.ModifyPlayerHeight(id, newHeigh);
        }

        public void ModifyPlayerWeight(int id, int newWeight)
        {
            playerRepo.ModifyPlayerWeight(id, newWeight);
        }

        public void ModifyPlayerPointsInSeason(int id, int newPoints)
        {
            playerRepo.ModifyPlayerPointsInSeason(id, newPoints);
        }

        public void ModifyPlayerNumberOfChampionships(int id, int newNumber)
        {
            playerRepo.ModifyPlayerNumberOfChampionships(id, newNumber);
        }

        public List<Players> TeamRoster(int idTeam)
        {
            var roster = from x in playerRepo.GetAll()
                         where x.idTeams == idTeam
                         orderby x.PName ascending
                         select x;

            List<Players> list = roster.ToList();

            return list;
        }

        public int TeamValue(int idTeam)
        {
            var roster = TeamRoster(idTeam);
            int value = 0;
            foreach (var item in roster)
            {
                value += item.PValue.Value;
            }

            return value;
        }
    }

    public class CoachLogic : ICoachLogic
    {
        private ICoachRepository coachRepo;

        public CoachLogic()
        {
            this.coachRepo = new CoachRepository(new NBA_DataEntities());
        }

        public CoachLogic(ICoachRepository repository)
        {
            this.coachRepo = repository;
        }

        public Coaches GetOne(int id)
        {
            return coachRepo.GetOne(id);
        }

        public List<Coaches> GetAll()
        {
            return coachRepo.GetAll().ToList();
        }

        public void Add(Coaches coach)
        {
            coachRepo.AddCoach(coach);
        }

        public void Delete(int id)
        {
            coachRepo.DeleteCoach(id);
        }

        public bool Champion(int id)
        {
            if (coachRepo.GetOne(id).NumberOfChampionships != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ModifyCoachWinPercentageInSeason(int id, double newPercentage)
        {
            coachRepo.ModifyCoachWinPercentageInSeason(id, newPercentage);
        }

        public void ModifyCoachNumberOfChampionships(int id, int newNumber)
        {
            coachRepo.ModifyCoachNumberOfChampionships(id, newNumber);
        }

        public void CoachOfTeam(int idTeam)
        {
            var coach = from x in coachRepo.GetAll()
                        where x.idTeams == idTeam
                        select x;
        }
    }

    class LogicClasses
    {
    }
}
