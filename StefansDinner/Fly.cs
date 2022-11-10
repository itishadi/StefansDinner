namespace StefansDinner;

public class Fly : IDinnerGuest
{
    public int Level { get; set; }
    private string Latest { get; set; }
    
    public void Act()
    {
        var items = new[] { "flyger", "surrar", "landar i maten" };

        var action = items[Game.Random.Next(items.Length)];


        Console.WriteLine($"Flugan {action}");

        Latest = action;

    }
    public void MightLevelUp()
    {
        if (Latest == "landar i maten") Level++;

        Console.WriteLine($"Flugans Level: {Level}");
    }
}