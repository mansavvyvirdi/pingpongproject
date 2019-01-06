using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongDataEntities;
using PingPongDataEntities.ViewModels;
using PingPongDataLayer;
using System.Linq;

namespace PingPongDataLayerTest
{
    [TestClass]
    public class PlayerUnitTest
    {
        [TestMethod]
        public void TestGetPlayerListMethod()
        {
            // Arrange
            PlayerData playerData = new PlayerData();

            // Act
            IEnumerable<PlayerViewModel> result = playerData.GetPlayerList();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreNotEqual(1, result.Count());

        }

        [TestMethod]
        public void TestGetSkillLevelListMethod1()
        {
            // Arrange
            PlayerData playerData = new PlayerData();

            // Act
            IEnumerable<SkillLevel> result = playerData.GetSkillLevelList();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Count());
            Assert.AreEqual(1, result.ElementAt(0).SkillLevelID);
            Assert.AreEqual(2, result.ElementAt(1).SkillLevelID);

        }

        [TestMethod]
        public void TestAddPlayerMethod()
        {
            // Arrange
            PlayerData playerData = new PlayerData();

            // Act
            Player player = new Player();
            player.FirstName = "test";
            player.LastName = "test";
            player.Age = 25;
            player.EmailAddress = "test@test.com";
            player.SkillLevelId = 1;
            Int32 data = playerData.AddOrUpdatePlayer(player);

            // Assert
            Assert.AreEqual(1, data);
        }

        [TestMethod]
        public void GetPlayerById()
        {
            // Arrange
            PlayerData playerData = new PlayerData();

            // Act
            Player result = playerData.GetPlayerById(2);

            // Assert
            Assert.AreEqual(2, result.PlayerId);
        }

        [TestMethod]
        public void TestUpdatePlayerMethod()
        {
            // Arrange
            PlayerData playerData = new PlayerData();

            // Act
            Player player = new Player();
            player.PlayerId = 1;
            player.FirstName = "test_updated";
            player.LastName = "test";
            player.Age = 25;
            player.EmailAddress = "test@test.com";
            player.SkillLevelId = 1;
            Int32 data = playerData.AddOrUpdatePlayer(player);

            // Assert
            Assert.AreEqual(1, data);
        }



        [TestMethod]
        public void TestDeletePlayerMethod()
        {
            // Arrange
            PlayerData playerData = new PlayerData();

            // Act
            Int32 data = playerData.DeletePlayer(1);

            // Assert
            Assert.AreEqual(1, data);
        }
    }
}
