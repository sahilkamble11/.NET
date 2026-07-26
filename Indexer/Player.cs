using System.Data.Common;

namespace WorldCup;

public class Player
{
    public int PlayerId{get;set;}
    public string PlayerName{get;set;}
    public int JerseyNo{get;set;}
    public string Position{get;set;}
    public double Salary{get;set;}

    public Player(int id,string name,int jerseyNo,string position,double salary)
    {
        this.PlayerId=id;
        this.PlayerName=name;
        this.JerseyNo=jerseyNo;
        this.Position=position;
        this.Salary=salary;
    }

    public override string ToString()
    {
        return "Id= "+PlayerId+" Player Name= "+PlayerName+" Jersey No.= "+JerseyNo+" Position= "+Position+" Salary= "+Salary;
    }
}