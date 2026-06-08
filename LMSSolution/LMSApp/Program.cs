
namespace LMS;
using LMSApp.Managers;
public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
        UIManager uiMgr=new UIManager();
        uiMgr.DisplayMainMenu(); 
        }   
         
    }
}