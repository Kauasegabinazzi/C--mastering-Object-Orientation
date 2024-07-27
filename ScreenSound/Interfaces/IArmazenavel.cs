namespace ScreenSound.Interfaces;

public interface IArmazenavel
{
    void Save();
    void Recover();
}

public class File : IArmazenavel
{
    public string ?FileName { get; set; }

    public void Save()
    {
        Console.WriteLine($"Saving data on file {FileName}.");
    }

    public void Recover()
    {
        Console.WriteLine($"Recovering data on file {FileName}.");
    }
}

public class DataBase : IArmazenavel
{
    public string ?BankName { get; set; }

    public void Save()
    {
        Console.WriteLine($"Saving data on data base {BankName}.");
    }

    public void Recover()
    {
        Console.WriteLine($"Recovering data on data base {BankName}.");
    }
}