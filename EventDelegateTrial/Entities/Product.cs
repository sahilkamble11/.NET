namespace Shopping;
using Agents;
public class Product
{
    public string ProductName{get; set;}
    public event DeliveryAgent DeliveryInform;
    public event ProcessingAgent ProcessInform;

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void OrderProcessed(string ProductName)
    {
        Console.WriteLine($"Your order of {ProductName} has been sucessfully processed....");
        ProcessInform.Invoke("Order Processed Event Automatically called");
    }

    public void OrderDelivered(string ProductName)
    {
        Console.WriteLine($"Your order of {ProductName} has been sucessfully delivered....");
        DeliveryInform.Invoke("Order Delivered Event Automatically called");
    }

}