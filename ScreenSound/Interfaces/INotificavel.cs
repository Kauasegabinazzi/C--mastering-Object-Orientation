namespace ScreenSound.Interfaces;

public interface INotificavel
{
    void SendNotification();
}

public class Email : INotificavel
{
    public string ?EmailAddress { get; set; }

    public void SendNotification()
    {
        Console.WriteLine($"Sending email to {EmailAddress}");
    }
}

public class SMS : INotificavel
{
    public string ?PhoneNumber { get; set; }

    public void SendNotification()
    {
        Console.WriteLine($"Sending SMS to {PhoneNumber}");
    }
}

