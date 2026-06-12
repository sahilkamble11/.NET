namespace Managers;
using Delegates;
public class PolicyManager
{      
    public event InsuranceAction ?PolicyPurchased;
    public event InsuranceAction PremiumPay;
    public event InsuranceAction ClaimRegister;
    public event InsuranceAction PolicyRenew;
   
   
    public void PurchasePolicy(string message)
    {
        Console.WriteLine("Policy Purchased");
        PolicyPurchased?.Invoke("Policy Purchased called");
    }

     public void PremiumPaid(string message)
    {
        Console.WriteLine("Policy Purchased");
        PremiumPay.Invoke("Premium Paid called");
    }

     public void ClaimRegistered(string message)
    {
        Console.WriteLine("Policy Purchased");
        ClaimRegister.Invoke("Claim Registered called");
    }

     public void PolicyRenewed(string message)
    {
        Console.WriteLine("Policy Purchased");
        PolicyRenew.Invoke("Policy Renewed called");
    }


}

