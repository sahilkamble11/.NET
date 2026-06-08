namespace Training;
public class Student
{
    public virtual void Build()
    {
        Console.WriteLine("Building project");
    }
}

public class JavaStudent:Student
{
    public override  void Build()
    {
        Console.WriteLine("Building  java project");
    }
}

public class ReactStudent:Student
{
    public override void Build()
    {
        Console.WriteLine("Building  react project");
    }
}