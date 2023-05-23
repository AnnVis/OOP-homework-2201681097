using Football_2201681097_OOP_hw;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Football_player> players = new List<Football_player>();
        players.Add(new Football_player("John", 26, 2, 167));
        players.Add(new Football_player("Kris", 37, 4, 181));
        players.Add(new Football_player("Modi", 20, 11, 174));
        Coach coach = new Coach("Stef", 48);
        Referee referee = new Referee("Gorge", 50);
        Team team = new Team(coach, players);
        Game game = new Game(team, team);
       // Console.WriteLine($"Sreden wyzrast: {team.GetAveragePlayerAge}");
    }
}