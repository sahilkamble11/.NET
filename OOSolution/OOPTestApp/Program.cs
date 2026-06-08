namespace OOPsAppp;
using Training;

public class Program
{  
    public static void Main(string [] args)
    {     
        Student [] students =[new Student(),new JavaStudent(), new  ReactStudent()];
        foreach( Student s in students)
        {
            s.Build();
        }    
    }
}

