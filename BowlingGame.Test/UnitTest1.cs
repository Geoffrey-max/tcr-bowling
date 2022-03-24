using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFrame()
        {
            // Arrange
            int scoreFrame = 0;
            int maxThrows = 2;
            int nbPlayers = 3;
            
            //Constructor BowlingGame(score, nbPlayers)
            //nbPlayers : list of Players
            var game = new BowlingGame(0, nbPlayers);
            
            // Assert
            Assert.Equals(nbPlayers, game.nbPlayers);
        }
    }
}