namespace BaggageSorting;

internal class Program
{
    public static void Main(string[] args)
    {
        Airline SAS = new(12, 2);
        Airline KLM = new(12, 2);
        Airline LOT = new(12, 2);
        Airline IAG = new(12, 2);

        Console.WriteLine($"{SAS.SorterAmount} {SAS.CheckInAmount}");

        SAS.CheckInAmount = 100;
        SAS.SorterAmount = 100;

        Console.WriteLine($"{SAS.SorterAmount} {SAS.CheckInAmount}");

        while (true) {
            Console.WriteLine(Random.Shared.Next(0, 4));
            Thread.Sleep(100/15);
        }
    }
}

internal class Airline
{
    private int _sorterAmount;
    public int SorterAmount
    {
        get => _sorterAmount;
        set => _sorterAmount = value;
    }

    private int _checkInAmount;
    public int CheckInAmount
    {
        get => _checkInAmount;
        set => _checkInAmount = value;
    }

    public Airline(int sorterAmount, int checkInAmount)
    {
        _sorterAmount = sorterAmount;
        _checkInAmount = checkInAmount;
    }
}

internal class Sorter
{
    public Sorter(Airline airline)
    {
    }
}

internal class CheckIn
{
    internal static Queue<Baggage> BaggageList = new();
    private int Id;
    public CheckIn(int id, Airline airline)
    {
        Id = id;
    }

    internal void CloseCheckIn()
    {

    }

    internal void OpenCheckIn()
    {

    }
}

internal class Gate
{
    public Gate(Airline airline)
    {
    }

    internal void OpenGate()
    {

    }

    internal void CloseGate()
    {

    }
}

internal class Baggage
{
    internal Baggage()
    {
    }
}
