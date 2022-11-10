namespace StefansDinner;

public class Telefon : IDinnerGuest
{
    public void Act()
    {
        int items = Game.Random.Next(0, 100);

        if (items > 95)
            Console.WriteLine("Enjoy!");
        else
            Console.WriteLine("Pick up the phone");
    }
    public void MightLevelUp()
    {

    }

}