namespace WorldCup;

public class Program
{
    public static void Main(String [] args)
    {
        // Team fc=new Team();
        // string playerName=fc[0].PlayerName;
        // Console.WriteLine("Player= "+playerName);

        // fc[0].PlayerName="Sahil Bajrang Kamble";
        // string playerName1=fc[0].PlayerName;
        // Console.WriteLine("Player= "+playerName1);

        List<Player> portugal=new List<Player>();
        portugal.Add(new Player(1, "Diogo Costa", 1, "Goalkeeper", 1200000));
        portugal.Add(new Player(2, "Joao Cancelo", 20, "Right Back", 1500000));
        portugal.Add(new Player(3, "Ruben Dias", 3, "Center Back", 1800000));
        portugal.Add(new Player(4, "Goncalo Inacio", 14, "Center Back", 1100000));
        portugal.Add(new Player(5, "Nuno Mendes", 19, "Left Back", 1600000));
        portugal.Add(new Player(6, "Joao Palhinha", 6, "Defensive Midfielder", 1300000));
        portugal.Add(new Player(7, "Bruno Fernandes", 8, "Central Midfielder", 2000000));
        portugal.Add(new Player(8, "Bernardo Silva", 10, "Attacking Midfielder", 1900000));
        portugal.Add(new Player(9, "Rafael Leao", 17, "Left Winger", 1800000));
        portugal.Add(new Player(10, "Cristiano Ronaldo", 7, "Striker", 2500000));
        portugal.Add(new Player(11, "Pedro Neto", 21, "Right Winger", 1400000));

        foreach(Player player in portugal)
        {
            Console.WriteLine(player);
        }
    }
}