using ScreenSound.Workshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Workshop;

public class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string LicensePlate { get; set; }

    public Vehicle(string brand, string model, int year, string license)
    {
        Brand = brand;
        Model = model;
        Year = year;
        LicensePlate = license;
    }
}

public class Mechanics
{
    public string Name { get; set; }
    public string Specialty { get; set; }

    public Mechanics(string name, string specialty)
    {
        Name = name;
        Specialty = specialty;
    }
}

public class Workshop
{
    private List<Vehicle> WorkshopVehicles;

    public Workshop()
    {
        WorkshopVehicles = new List<Vehicle>();
    }

    public void SchedulingService(Vehicle vehicle, Client client, Mechanics mechanic, string schedulingDates)
    {
        WorkshopVehicles.Add(vehicle);

        // Lógica para agendar o serviço (pode ser expandida conforme necessário)
        Console.WriteLine($"Serviço agendado para {vehicle.LicensePlate} em {schedulingDates} com o mecânico {mechanic.Name}.");
    }

    public void DoService(Vehicle vehicle, Mechanics mechanic)
    {
        if (WorkshopVehicles.Contains(vehicle))
        {

            Console.WriteLine($"Serviço realizado em {vehicle.LicensePlate} pelo mecânico {mechanic.Name}.");
            WorkshopVehicles.Remove(vehicle);
        }
        else
        {
            Console.WriteLine($"O veículo {vehicle.LicensePlate} não está na oficina para realizar o serviço.");
        }
    }
}

public class Client
{
    public string Name { get; set; }
    public string Contact { get; set; }

    public Client(string name, string contact)
    {
        Name = name;
        Contact = contact;
    }
}
