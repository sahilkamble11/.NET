using System.Reflection.Metadata;

namespace Managers;

public class UIManager
{
    private readonly PolicyManager policyManager;
    
    public UIManager(PolicyManager policyManager)
    {
        this.policyManager = policyManager;
    }

    public void DisplayMenu()
    {
         
        Console.WriteLine("====================================");
        Console.WriteLine("      Insurance Management System");
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine("1. Purchase Policy");
        Console.WriteLine("2. Pay Premium");
        Console.WriteLine("3. Register Claim");
        Console.WriteLine("4. Renew Policy");
        Console.WriteLine("5. Exit");
        Console.WriteLine();
        Console.Write("Enter Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        HandleMenuChoice(choice);
        
    }   

    public void HandleMenuChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                policyManager.PurchasePolicy("hi");
            break;
        }
    }
}