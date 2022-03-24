namespace BowlingGame;

public class Player
{
    private string name;
    private int score;

    public Player(string name)
    {
        this.name = name;
        score = 0;
    }

    public int launchThrow()
    {
        Random rnd = new Random();
        int throwScore = rnd.Next(0, 11);
        score += throwScore;
        return throwScore;
    }
}