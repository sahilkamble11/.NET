namespace HrApp;
using HR;
using HR.SalesEmployee;
using HR.SalesManager;

public class Program
{
    public static void Main(string [ ] args)
    {
        SalesEmployee salesEmployee=new SalesEmployee(800000,2000,5000);
        SalesManager salesManager=new SalesManager(800000,2000,5000,10000);
        
        //salesEmployee.ComputePay();
        salesManager.ComputePay();
        
        //Console.Write("Hello Nirjala <3 !!!");
    }
}