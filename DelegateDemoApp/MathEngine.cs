namespace Engine;

public class MathEngine
{
    public delegate double MathOperation(double a, double b);
    public static double  Add(double a, double b)
    {
        return a+b;
    }

    public static double Subtract(double a, double b)
    {
        return a-b;
    }

    public static double Multiply(double a, double b)
    {
        return a*b;
    }
    public static double Divide(double a, double b)
    {
        return a/b;
    }

    public MathOperation mathAdd=new MathOperation(Add);
    public MathOperation mathSubtract=new MathOperation(Subtract);
    public MathOperation mathMultiply=new MathOperation(Multiply);
    public MathOperation mathDivide=new MathOperation(Divide);

}