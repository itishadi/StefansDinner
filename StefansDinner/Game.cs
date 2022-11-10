using StefansDinner;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace StefansDinner;

public interface IDinnerGuest
{
    void Act();
    void MightLevelUp(string res);
}
//

public class Telefon : IDinnerGuest
{
    public void Act()
    {
        // slumptal mellab 0 och 100
        //  int items = 100;
        int items = Game.Random.Next(0, 100);

        if (items > 95)
            Console.WriteLine("Enjoy!");
        else
            Console.WriteLine("Pick up the phone");
    }
    public void MightLevelUp(string res)
    {

    }

}




//
public class Fly : IDinnerGuest
{
    public int Level { get; set; }
    public int Counter { get; set; }
    public void Act()
    {
        var items = new[] { "flyger", "surrar", "landar i maten" };

        Console.WriteLine($"Flugan {items[Game.Random.Next(items.Length)]}");
    }
    public void MightLevelUp(string res)
    {
        Console.WriteLine("Jag kan inte rapa!");
    }
}
public class Human : IDinnerGuest
{
    public Human(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public int Level { get; set; }
    public int Counter { get; set; }
    public void Act()
    {

        var items = new[] { "rapar", "äter", "dricker", "pratar" };
        string result = items[Game.Random.Next(items.Length)];
        Console.WriteLine($"{Name} {result}");

        MightLevelUp(result);

    }
    public void MightLevelUp(string res)
    {
        //Humans och Fly ska ha en Level.
        //Om Human rapar tre gånger på raken så ska den levla up (+1)
        //Om en Fly landar i maten så ska den levla up (+1)


        if (res == "rapar")
        {
            Counter++;
            if (Counter == 3)
            {
                Level++;
            }
            else
            {
                Level = 0;
            }
            
        }
        Console.WriteLine("Level " + Level);
    }
}







public class Game
{
    public static Random Random = new Random();

    public List<IDinnerGuest> guests = new List<IDinnerGuest>();

    public Game()
    {
        guests.Add(new Human("Stefan"));
        guests.Add(new Human("Richard"));
        guests.Add(new Human("Kerstin"));
        guests.Add(new Human("Oliver"));
        guests.Add(new Fly());
        guests.Add(new Telefon());
    }
    public void Run()
    {
        foreach (var x in guests)
            x.Act();
    }
}

