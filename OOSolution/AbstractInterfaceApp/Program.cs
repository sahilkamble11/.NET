

namespace TestApp;

using TflDrawing;
public class Program
{
    public static void Main(string [] args)
    {
        Shape theShape= new Line();
        theShape.Draw();

        IPrintable printer=(IPrintable)theShape;

        printer.Print();
        printer.Draw();


    }
}