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

            var game = new BowlingGame(0);
            
            // Assert
            Assert.IsNotNull(scoreFrame);
        }
    }
}