// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace BowlingGame
{
    public class BowlingGame
    {
        private int maxThrows;
        private int iterations;
        public Player[] players;

        public BowlingGame(Player[] nbPlayers)
        {
            this.players = nbPlayers;
        }

        public void PlayGame()
        {
            foreach (var player in players)
            {
                
            }
        }
    }
}

