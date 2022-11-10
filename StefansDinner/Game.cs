using StefansDinner;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace StefansDinner;

//

//
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
        {
            x.Act();
            x.MightLevelUp();
        }
    }
}

