namespace WorldCup;

public class Team
{
    private Player [] players=new Player [11];

    public Team()
    {
        players [0] = new Player(1, "Gurpreet Singh Sandhu", 1, "Goalkeeper", 500000);
        players [1] = new Player(2, "Rahul Bheke", 2, "Right Back", 450000);
        players [2] = new Player(3, "Anwar Ali", 4, "Center Back", 480000);
        players [3] = new Player(4, "Sandesh Jhingan", 3, "Center Back", 600000);
        players [4] = new Player(5, "Subhasish Bose", 5, "Left Back", 470000);
        players [5] = new Player(6, "Jeakson Singh", 8, "Defensive Midfielder", 420000);
        players [6] = new Player(7, "Apuia", 14, "Central Midfielder", 430000);
        players [7] = new Player(8, "Brandon Fernandes", 10, "Attacking Midfielder", 520000);
        players [8] = new Player(9, "Lallianzuala Chhangte", 7, "Right Winger", 550000);
        players [9] = new Player(10, "Manvir Singh", 11, "Left Winger", 500000);
        players [10] = new Player(11, "Sunil Chhetri", 9, "Striker", 1000000);
    }

    public Player this[int index]
    {
        get
        {
            return players[index];
        }
        set
        {
            this.players[index]=value;
        }
    }
}