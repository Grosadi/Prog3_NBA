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
    class LogicTesting
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
                    NumberOfPlayedSeason = 1,
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
                },
            };


            this.mockRepo.Setup(x => x.GetAll()).Returns(players.AsQueryable); /*new List<Players>()
            {
                new Players()
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
                },
            }.AsQueryable);*/

            //this.mockRepo.Setup(x => x.GetOne(It.IsAny<Players>().idPlayers)).Returns(players.AsQueryable);

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
            Players p1 =  players.GetOne(1);
            Assert.That(p1.idPlayers == 1);
        }

        [Test]
        public void Test_DeletePlayer()
        {
            players.Delete(1);
            Assert.That(this.players.GetAll().Count == 2);
        }

        [Test]
        public void Test_PlayerChampion()
        {
            Assert.That(this.players.Champion(1) == false);
        }
    }
}
