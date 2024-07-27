namespace ScreenSound.Interfaces;

public interface IPagavel
{
    decimal CalculatePayment();
}

public class Produto : IPagavel
{
    public decimal UnitPrice { get; set; }
    public int Amount { get; set; }

    public decimal CalculatePayment()
    {
        return UnitPrice * Amount;
    }
}

public class Servico : IPagavel
{
    public decimal HourlyRate { get; set; }
    public int WorkedHours { get; set; }

    public decimal CalculatePayment()
    {
        return HourlyRate * WorkedHours;
    }
}
