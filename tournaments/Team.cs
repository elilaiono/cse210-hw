public class Team {

    private string _name;
    private List<Player> _roster = new List<Player>();
    private int _wins = 0;
    private int _loses = 0;


    public Team(string name)
    {
        _name = name;
    }


    public void AddPlayer(Player p)
    {
        _roster.Add(p);
    }

    public void DisplayRoster()
    {
        Console.WriteLine();
        Console.WriteLine(_name);
        Console.WriteLine($"wins: {_wins} loses:{_loses}");
        Console.WriteLine("------------------------------------");
        foreach (Player p in _roster)
        {
            p.Display();
        }
    }

    public void AddWin()
    {
        _wins += 1;
    }

    public void AddLoss()
    {
        _loses += 1;
    }

    public string GetTeamName()
    {
        return _name;
    }
}
