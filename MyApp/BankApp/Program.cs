using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using BankingApp;


public class Program
{

    void Calculate(float r,  out  float area, out   float c)
    {
        area = 3.14f * r * r;
        c = 2 * 3.14f * r;
    }

   //pass by reference
   public  void Swap( ref int num1, ref  int num2)
    {
        int temp =num1; 
        num1 = num2; 
        num2 = temp;

    }

 
    public static void ViewNames( params string []  names )
    {
        foreach( string name in names)
        {
            Console.WriteLine(name);
        }
        
        
    }

    //pass by 
    public int Add(int num1, int num2)
    {
        return num1+num2;

    }
    public static void Main(string [] args)
    {
      /*  
        SavingAccount acct2=new SavingAccount("Sejal Kulkarni",78000);
        acct2.balance=23000;
        acct2.balance=acct2.balance+78;


        int[] marks = new  int[] { 90, 80, 70 };
        string[] names=new string[]{"Chaitrali","Arnav","Samruddhi", "Tejas"};

        
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        ViewNames("Ajay", "Anirudha");
        ViewNames("Rajan", "Sachin", "karan");
        ViewNames("Rajan", "Sachin", "karan", "Sharada");
        ViewNames("Rajan", "Sachin", "karan", "Sharada", "Ganesh", "Sahil", "Kartik");
        */
        Program theProgram=new Program();

        int num1=67;
        int num2=98;
        Console.WriteLine( $" {num1}   {num2}");
        theProgram.Swap(ref num1, ref  num2);
        Console.WriteLine( $" {num1}   {num2}");

        float radius=15;
        float area;
        float circumference;
        theProgram.Calculate(radius,out area,  out circumference);
        Console.WriteLine( $" radius={radius}  area={area}  circumference={circumference}");
    }
}
