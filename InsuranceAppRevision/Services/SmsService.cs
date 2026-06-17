namespace Service;

public class SmsService:INotificationService
{
    public void SendMessage()
    {
        Console.WriteLine("SMS has been sent..");
    }
}