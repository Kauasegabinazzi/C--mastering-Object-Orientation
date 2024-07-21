using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.PetShop;


public class Pet
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }

    public Pet(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }

}

public class Doctor
{
    public string Name { get; set; }
    public string Specialty { get; set; }

    public Doctor(string name, string specialty)
    {
        Name = name;
        Specialty = specialty;
    }
}

public class Owner
{
    public string Name { get; set; }
    public string Contact { get; set; }

    public Owner(string name, string contact) {

        Name = name;
        Contact = contact;
    }
}

public class Appointment
{
    public Pet Animal { get; set; }
    public Owner OwerAnimal { get; set; }
    public Doctor Veterinary { get; set; }
    public string AppointmentDate { get; set; }

    public Appointment(Pet pet, Doctor doctor, Owner owner, string date)
    {
        Animal = pet;
        Veterinary = doctor;
        OwerAnimal = owner;
        AppointmentDate = date;
    }
}


