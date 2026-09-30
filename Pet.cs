using System.Dynamic;

namespace Husdjur_cleancode;

public class Pet
{
    public string Name { get; set; } = "";

    public string Animaltype { get; set; } = "";

    public string favoritfood { get; set;} = "";

    public void ReadInfo()
    {
        Console.WriteLine("What is your name?");
        Name = Console.ReadLine()?? "";
        Console.WriteLine("What type of animal are you?");
        Animaltype = Console.ReadLine()?? "";
        Console.WriteLine("What is your favoritefood?");
        favoritfood = Console.ReadLine()?? "";
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello My name is {Name} and i am a {Animaltype} and my favorite food is {favoritfood}");
    }
}

    





