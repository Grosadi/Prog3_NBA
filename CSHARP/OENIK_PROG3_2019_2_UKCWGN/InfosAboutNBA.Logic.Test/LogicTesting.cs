using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using InfosAboutNBA.Logic;
using InfosAboutNBA.Repository;
using InfosAboutNBA.Data;

namespace InfosAboutNBA.Logic.Test
{
     [TestFixture]
     internal class LogicTesting
    {
        [TestFixture]
        private class PlayerLogicTesting
        {
            private Mock<IPlayerRepository> mockRepo;
            private PlayerLogic players;

            [SetUp]
            public void Init()
            {
                this.mockRepo = new Mock<IPlayerRepository>();

                List<Players> players = new List<Players>()
            {
                new Players()
                {
                    idPlayers = 1,
                    PName = "player1",
                    Age = 20,
                    NumberOfPlayedSeason = 2,
                    Position = "PG",
                    Height = 190,
                    PWeight = 85,
                    NumberOfChampionships = 0,
                    LifetimePoints = 1000,
                },
                new Players()
                {
                    idPlayers = 2,
                    PName = "player2",
                    Age = 30,
                    NumberOfPlayedSeason = 2,
                    Position = "SG/SF",
                    Height = 200,
                    PWeight = 100,
                    NumberOfChampionships = 1,
                    LifetimePoints = 2500,
                    idTeams = 2,
                },
                new Players()
                {
                    idPlayers = 3,
                    PName = "player3",
                    Age = 27,
                    NumberOfPlayedSeason = 7,
                    Position = "C",
                    Height = 213,
                    PWeight = 117,
                    NumberOfChampionships = 3,
                    LifetimePoints = 15500,
                    idTeams = 2,
                },
            };

                this.mockRepo.Setup(x => x.GetAll()).Returns(players.AsQueryable);

                this.mockRepo.Setup(x => x.GetOne(It.IsAny<int>())).
                    Returns(new Players()
                    {
                        idPlayers = 1,
                        PName = "player1",
                        Age = 20,
                        NumberOfPlayedSeason = 1,
                        Position = "PG",
                        Height = 190,
                        PWeight = 85,
                        NumberOfChampionships = 0,
                        LifetimePoints = 1000,
                    });

                this.players = new PlayerLogic(this.mockRepo.Object);
            }

            [Test]
            public void Test_GetAllPlayers()
            {
                Assert.That(this.players.GetAll().Count == 3);
            }

            [Test]
            public void Test_GetOnePlayer()
            {
                Players p1 = this.players.GetOne(1);
                Assert.That(p1.idPlayers == 1);
                Assert.That(p1.Age == 20);
            }

            [Test]
            public void Test_PlayerChampion()
            {
                Assert.That(this.players.Champion(1) == false);
            }

            [Test]
            public void Test_TeamRoster()
            {
                Assert.That(this.players.TeamRoster(2).Count == 2);
            }
        }

        [TestFixture]
        private class TeamLogicTesting
        {
            private Mock<ITeamRepository> mockRepo;
            private TeamLogic team;

            [SetUp]
            public void Init()
            {
                this.mockRepo = new Mock<ITeamRepository>();

                List<Teams> teams = new List<Teams>()
                {
                    new Teams()
                    {
                        idTeams = 1,
                        TName = "team1",
                        HomeTown = "cityOne",
                        Found = 2000,
                        WinPercentageSinceFounded = 0.500,
                        NumberOfChampionships = 0,
                    },

                    new Teams()
                    {
                        idTeams = 2,
                        TName = "team2",
                        HomeTown = "cityTwo",
                        Found = 1990,
                        WinPercentageSinceFounded = 0.350,
                        NumberOfChampionships = 1,
                    },

                    new Teams()
                    {
                        idTeams = 3,
                        TName = "team3",
                        HomeTown = "cityThree",
                        Found = 1950,
                        WinPercentageSinceFounded = 0.675,
                        NumberOfChampionships = 10,
                    },
                };

                this.mockRepo.Setup(x => x.GetAll()).Returns(teams.AsQueryable());
                this.mockRepo.Setup(x => x.GetOne(It.IsAny<int>())).Returns(
                     new Teams()
                     {
                         idTeams = 1,
                         TName = "team1",
                         HomeTown = "cityOne",
                         Found = 2000,
                         WinPercentageSinceFounded = 0.500,
                         NumberOfChampionships = 0,
                     });

                this.team = new TeamLogic(this.mockRepo.Object);
            }

            [Test]
            public void Test_GetAllTeam()
            {
                Assert.That(this.team.GetAll().Count == 3);
            }

            [Test]
            public void Test_GetOneTeam()
            {
                Assert.That(this.team.GetOne(1).idTeams == 1);
                Assert.That(this.team.GetOne(1).TName == "team1");
            }

            [Test]
            public void Test_ChampionTeam()
            {
                Assert.That(this.team.Champion(1) == false);
            }

            [Test]
            public void Test_RankingAllTime()
            {
                Assert.That(this.team.RankingAllTime().Count == 3);
                Assert.That(this.team.RankingAllTime().First().TName == "team3");
            }
        }

        [TestFixture]
        private class CoachLogicTesting
        {
            private Mock<ICoachRepository> mockRepo;
            private CoachLogic coach;

            [SetUp]
            public void Init()
            {
                this.mockRepo = new Mock<ICoachRepository>();

                List<Coaches> coaches = new List<Coaches>()
                {
                    new Coaches()
                    {
                        idCoaches = 1,
                        CName = "coach1",
                        NumberOfChampionships = 0,
                        NumberOfSeasons = 3,
                        WinPercentage = 0.450,
                        idTeams = 1,
                    },

                    new Coaches()
                    {
                        idCoaches = 2,
                        CName = "coach2",
                        NumberOfSeasons = 10,
                        NumberOfChampionships = 3,
                        WinPercentage = 0.675,
                        PreviusTeam = "team2",
                        idTeams = 2,
                    },

                    new Coaches()
                    {
                        idCoaches = 3,
                        CName = "coach3",
                        NumberOfSeasons = 25,
                        NumberOfChampionships = 5,
                        WinPercentage = 0.550,
                        idTeams = 3,
                    },
                };

                this.mockRepo.Setup(x => x.GetAll()).Returns(coaches.AsQueryable());
                this.mockRepo.Setup(x => x.GetOne(It.IsAny<int>())).Returns(
                    new Coaches()
                    {
                        idCoaches = 1,
                        CName = "coach1",
                        NumberOfChampionships = 0,
                        NumberOfSeasons = 3,
                        WinPercentage = 0.450,
                        idTeams = 1,
                    });

                this.coach = new CoachLogic(this.mockRepo.Object);
            }

            [Test]
            public void Test_GetAllCoach()
            {
                Assert.That(this.coach.GetAll().Count == 3);
            }

            [Test]
            public void Test_GetOneCoach()
            {
                Assert.That(this.coach.GetOne(1).idCoaches == 1);
                Assert.That(this.coach.GetOne(1).CName == "coach1");
            }

            [Test]
            public void Test_ChampionCoach()
            {
                Assert.That(this.coach.Champion(1) == false);
            }

            [Test]
            public void Test_CoachOfTeam()
            {
                Assert.That(this.coach.CoachOfTeam(1).CName == "coach1");
            }
        }
    }
}
