namespace StefansDinner;

public class Human : IDinnerGuest
{
    public Human(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
    public int Level { get; set; }
    public int Counter { get; set; }
    private string Latest { get; set; }
    public void MightLevelUp()
    {
        if (Latest == "rapar")
        {
            if (Counter == 3)
            {
                Level++;
            }
        }
        Console.WriteLine("Level " + Level);
    }
    public void Act()
    {
        var items = new[] { "rapar", "äter", "dricker", "pratar" };
        string result = items[Game.Random.Next(items.Length)];
        Console.WriteLine($"{Name} {result}");

        if (result == "rapar") Counter++;
        else Counter = 0;

        Latest = result;
    }
}