namespace PolicyManagerApp;
using Managers.Insurance;
using Managers.UI;

public class Program
{
    
    public static void Main(string [] args)
    {
        InsurancePolicyManager insPolicyMgr= new InsurancePolicyManager();
        UIManager ui=new UIManager(insPolicyMgr);

        while(true){
        ui.DisplayMenu();
        }
        
    }
}