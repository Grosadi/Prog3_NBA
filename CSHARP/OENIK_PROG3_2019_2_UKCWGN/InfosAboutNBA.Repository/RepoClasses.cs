using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfosAboutNBA.Data;

namespace InfosAboutNBA.Repository
{
    public interface IRepository<T>
        where T : class
    {
        T GetOne(int id);

        IQueryable<T> GetAll();
    }

    public interface ITeamRepository : IRepository<Teams>
    {
        void AddTeam(Teams team);

        Teams GetOne(int id);

        void ModifyTeamWinPercentageInSeason(int id, double newPercentage);

        void ModifyTeamNumberOfChampionships(int id, int newNumber);

        void DeleteTeam(int id);
    }

    public class TeamRepository : ITeamRepository
    {
        private NBA_DataEntities entities;

        public TeamRepository(NBA_DataEntities entities)
        {
            this.entities = entities;
        }

        public void AddTeam(Teams team)
        {
            entities.Teams.Add(team);
            entities.SaveChanges();
        }

        public void DeleteTeam(int id)
        {
            entities.Teams.Remove(this.GetOne(id));
            entities.SaveChanges();
        }

        public IQueryable<Teams> GetAll()
        {
            return entities.Teams;
        }

        public Teams GetOne(int id)
        {
            return entities.Teams.Where(x => x.idTeams == id).FirstOrDefault();
        }

        public void ModifyTeamNumberOfChampionships(int id, int newNumber)
        {
            var team = GetOne(id);
            team.NumberOfChampionships = newNumber;
            entities.SaveChanges();
        }

        public void ModifyTeamWinPercentageInSeason(int id, double newPercentage)
        {
            var team = GetOne(id);
            team.WinPercentageInSeason = newPercentage;
            entities.SaveChanges();
        }
    }

    public interface IPlayerRepository : IRepository<Players>
    {
        void AddPlayer(Players player);

        Players GetOne(int id);

        void ModifyPlayerAge(int id, int newAge);

        void ModifyPlayerHeight(int id, int newHeigh);

        void ModifyPlayerWeight(int id, int newWeight);

        void ModifyPlayerPointsInSeason(int id, int newPoints);

        void ModifyPlayerNumberOfChampionships(int id, int newNumber);

        void DeletePlayer(int id);
    }

    public class PlayerRepository : IPlayerRepository
    {
        private NBA_DataEntities entities;

        public PlayerRepository(NBA_DataEntities entities)
        {
            this.entities = entities;
        }

        public void AddPlayer(Players player)
        {
            entities.Players.Add(player);
            entities.SaveChanges();
        }

        public void DeletePlayer(int id)
        {
            entities.Players.Remove(this.GetOne(id));
            entities.SaveChanges();
        }

        public IQueryable<Players> GetAll()
        {
            return entities.Players;
        }

        public Players GetOne(int id)
        {
            return entities.Players.Where(x => x.idPlayers == id).FirstOrDefault();
        }

        public void ModifyPlayerAge(int id, int newAge)
        {
            var player = GetOne(id);
            player.Age = newAge;
            entities.SaveChanges();
        }

        public void ModifyPlayerHeight(int id, int newHeigh)
        {
            var player = GetOne(id);
            player.Height = newHeigh;
            entities.SaveChanges();
        }

        public void ModifyPlayerNumberOfChampionships(int id, int newNumber)
        {
            var player = GetOne(id);
            player.NumberOfChampionships = newNumber;
            entities.SaveChanges();
        }

        public void ModifyPlayerPointsInSeason(int id, int newPoints)
        {
            var player = GetOne(id);
            player.PointsInSeason = newPoints;
            entities.SaveChanges();
        }

        public void ModifyPlayerWeight(int id, int newWeight)
        {
            var player = GetOne(id);
            player.PWeight = newWeight;
            entities.SaveChanges();
        }
    }

    public interface ICoachRepository : IRepository<Coaches>
    {
        void AddCoach(Coaches coach);

        Coaches GetOne(int id);

        void ModifyCoachWinPercentageInSeason(int id, double newPercentage);

        void ModifyCoachNumberOfChampionships(int id, int newNumber);

        void DeleteCoach(int id);
    }

    public class CoachRepository : ICoachRepository
    {
        private NBA_DataEntities entities;

        public CoachRepository(NBA_DataEntities entities)
        {
            this.entities = entities;
        }

        public void AddCoach(Coaches coach)
        {
            entities.Coaches.Add(coach);
            entities.SaveChanges();
        }

        public void DeleteCoach(int id)
        {
            entities.Coaches.Remove(this.GetOne(id));
            entities.SaveChanges();
        }

        public IQueryable<Coaches> GetAll()
        {
            return entities.Coaches;
        }

        public Coaches GetOne(int id)
        {
            return entities.Coaches.Where(x => x.idCoaches == id).FirstOrDefault();
        }

        public void ModifyCoachNumberOfChampionships(int id, int newNumber)
        {
            var coach = GetOne(id);
            coach.NumberOfChampionships = newNumber;
            entities.SaveChanges();
        }

        public void ModifyCoachWinPercentageInSeason(int id, double newPercentage)
        {
            var coach = GetOne(id);
            coach.WinPercentage = newPercentage;
            entities.SaveChanges();
        }
    }

    class RepoClasses
    {
    }
}
