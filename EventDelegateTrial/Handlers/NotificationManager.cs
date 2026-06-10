using Shopping;

namespace Handler;

public class NotificationManager
{
    Product product = new Product();
    public void SendEmail(string email)
    {
        Console.WriteLine($"Email has been Sucessfully sent");
    }
}