namespace Integrate;
using Shopping;
using Agents;
using Handler;

public class Program
{
public static void Main(string [] args)
    {
        Product p=new Product();
        NotificationManager notificationManager=new NotificationManager();

        p.DeliveryInform+=notificationManager.SendEmail;
        p.ProcessInform+=notificationManager.SendEmail;
        p.DeliveryInform+=p.PrintMessage;
        p.ProcessInform+=p.PrintMessage;

        p.OrderDelivered("Mobile");
        p.OrderProcessed("Laptop");

    }
}