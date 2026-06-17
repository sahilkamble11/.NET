namespace HR.SalesEmployee;

using System.Reflection.Metadata.Ecma335;
using HR;

public class SalesEmployee:Employee
{
    public double Salary;
    public double Incentives;
    public double Hra;

    public SalesEmployee()
    {
        Salary=0;
        Incentives=0;
        Hra=0;
    }

    public SalesEmployee(double sal,double incen,double hra)
    {
        this.Salary=sal;
        this.Incentives=incen;
        this.Hra=hra;
    }
    public double ComputePay()
    {
        double TotalSalary=Salary+Incentives+Hra;
        Console.WriteLine($"Total Salary of Sales Employee is : {TotalSalary}");
        return 0;
        }
}
