namespace BaggageSorting;

internal class Program {
    public static void Main(string[] args) {
        Airline SAS = new(12, 2);
        Airline KLM = new(12, 2);
        Airline LOT = new(12, 2);
        Airline IAG = new(12, 2);

        Console.WriteLine($"{SAS.SorterAmount} {SAS.CheckInAmount}");

        SAS.CheckInAmount = 100;
        SAS.SorterAmount = 100;

        Console.WriteLine($"{SAS.SorterAmount} {SAS.CheckInAmount}");
    }
}

internal class Airline {
    private int _sorterAmount;
    public int SorterAmount {
        get => _sorterAmount;
        set => _sorterAmount = value;
    }

    private int _checkInAmount;
    public int CheckInAmount {
        get => _checkInAmount;
        set => _checkInAmount = value;
    }

    public Airline(int sorterAmount, int checkInAmount) {
        _sorterAmount = sorterAmount;
        _checkInAmount = checkInAmount;
    }
}

internal class Sorter {
    public Sorter(Airline airline) {
    }
}

internal class CheckIn {
    internal static Queue<Baggage> BaggageList = new();
    private readonly int Id;

    public CheckIn(int id, Airline airline) => this.Id = id;

    internal static void CloseCheckIn() {

    }

    internal static void OpenCheckIn() {

    }
}

internal class Gate {
    public Gate(Airline airline) {
    }

    internal static void OpenGate() {

    }

    internal static void CloseGate() {

    }
}

internal class Baggage {
    internal Baggage() {
    }
}
