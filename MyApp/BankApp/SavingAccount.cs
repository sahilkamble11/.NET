
namespace BankingApp;

public class SavingAccount
{
    public readonly string accountHolder;
    public double balance;
    public  const double interestRate=7;

    public SavingAccount()
    {  
    }

    public SavingAccount(string name, double amount)
    {
        this.accountHolder=name;
        this.balance=amount;
    }


    public void Withdraw(double amount)
    {
        this.balance=this.balance-amount;
    }

     public void Deposit(double amount)
    {
      
        this.balance=this.balance+amount;
    }

    
}