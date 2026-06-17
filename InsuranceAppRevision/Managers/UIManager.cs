namespace Managers.UI;
using Managers;
using Managers.Insurance;
using PolicyManagerApp;

public class UIManager
{
    InsurancePolicyManager insPolicyMgr;
    public UIManager(InsurancePolicyManager insPolicyMgr)
    {
        this.insPolicyMgr=insPolicyMgr;
    }
    public void DisplayMenu()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("Insurance Management System");
        Console.WriteLine("====================================");
        Console.WriteLine("");
        Console.WriteLine("1. Purchase Policy");
        Console.WriteLine("2. Pay Premium");
        Console.WriteLine("3. Register Claim");
        Console.WriteLine("4. Renew Policy");
        Console.WriteLine("5. Exit");
        Console.WriteLine("");
        Console.Write("Enter Choice:");

        int choice=int.Parse(Console.ReadLine());
        HandleDisplayMenuChoice(choice);
    }

    public void HandleDisplayMenuChoice(int num)
    {
        switch (num)
        {
            case 1:
            insPolicyMgr.PurchasePolicy();
            break;

            case 2:
            insPolicyMgr.PayPremium();
            break;

            case 3:
            insPolicyMgr.RegisterClaim();
            break;

            case 4:
            insPolicyMgr.RenewPolicy();
            break;

            case 5:
            Environment.Exit(0);
            break;
           
        }
    }
}