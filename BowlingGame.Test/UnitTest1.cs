using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPlayersCount()
        {
            // Arrange
            int maxThrows = 2;
            Player player1 = new Player("Maya Hi");
            Player player2 = new Player("Maya Hou");
            Player player3 = new Player("Maya Ha");
            Player player4 = new Player("Maya Ha ha");
            Player[] players = new Player[3];
            players[0] = player1;
            players[1] = player2;
            players[2] = player3;
            players[3] = player4;

            
            //Constructor BowlingGame(score, nbPlayers)
            //nbPlayers : list of Players
            var game = new BowlingGame(players);

            foreach (var player in players)
            {
                Assert.IsNotNull(player.launchThrow());
                Assert.IsTrue(player.score >= 0);
            }
            
            // Assert
            Assert.AreEqual(players.Length, game.players.Length);
            
        }
    }
}