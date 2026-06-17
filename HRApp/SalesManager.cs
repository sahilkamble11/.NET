namespace HR.SalesManager;
using HR;
using HR.SalesEmployee;

public class SalesManager : SalesEmployee,Employee
{
    double bonus;

    public SalesManager()
    {
    }

    public SalesManager(double sal,double incen,double hra,double bonus) : base(sal, incen, hra)
    {
        this.Salary=sal;
        this.Incentives=incen;
        this.Hra=hra;
        this.bonus=bonus;
    }
    public double ComputePay()
    {
        double Total= bonus + base.ComputePay() ;
        Console.WriteLine($"Total Salary Of Sales Manager is : {Total}");
        return 0;
    }
}