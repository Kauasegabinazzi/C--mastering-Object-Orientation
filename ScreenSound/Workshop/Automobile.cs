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

public class Mecanico
{
    public string Nome { get; set; }
    public string Especialidade { get; set; }

    public Mecanico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
}

public class Oficina
{
    private List<Veiculo> veiculosNaOficina;

    public Oficina()
    {
        veiculosNaOficina = new List<Veiculo>();
    }

    public void AgendarServico(Veiculo veiculo, Cliente cliente, Mecanico mecanico, string dataAgendamento)
    {
        veiculosNaOficina.Add(veiculo);

        // Lógica para agendar o serviço (pode ser expandida conforme necessário)
        Console.WriteLine($"Serviço agendado para {veiculo.Placa} em {dataAgendamento} com o mecânico {mecanico.Nome}.");
    }

    public void RealizarServico(Veiculo veiculo, Mecanico mecanico)
    {
        if (veiculosNaOficina.Contains(veiculo))
        {

            Console.WriteLine($"Serviço realizado em {veiculo.Placa} pelo mecânico {mecanico.Nome}.");
            veiculosNaOficina.Remove(veiculo);
        }
        else
        {
            Console.WriteLine($"O veículo {veiculo.Placa} não está na oficina para realizar o serviço.");
        }
    }
}

public class Cliente
{
    public string Nome { get; set; }
    public string Contato { get; set; }

    public Cliente(string nome, string contato)
    {
        Nome = nome;
        Contato = contato;
    }
}
