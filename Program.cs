namespace Husdjur_cleancode;

class Program
{
    static void Main(string[] args)
    {
        CreateAndIntroducePets();
        Console.ReadLine();
    }

    static void CreateAndIntroducePets()
    {
        Console.WriteLine("Här kommer husdjuren!");

        Pet pet1 = new Pet();
        Console.WriteLine("Pet 1:");
        pet1.ReadInfo();

        Pet pet2 = new Pet();
        Console.WriteLine("Pet 2:");
        pet2.ReadInfo();

        pet1.Introduce();
        pet2.Introduce();
        
    }
}