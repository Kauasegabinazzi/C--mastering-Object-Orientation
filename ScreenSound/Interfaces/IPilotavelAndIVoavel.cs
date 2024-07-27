namespace ScreenSound.Interfaces;

public interface IPilotavel
{
    void Pilot();
}

public interface IVoavel
{
    void Fly();
}

public class Vehicle : IPilotavel, IVoavel
{
    public void Pilot()
    {
        Console.WriteLine("Vehicle is driving");
    }

    public void Fly()
    {
        Console.WriteLine("Vehicle is flying");
    }
}