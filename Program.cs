namespace BaggageSorting;

internal class Program {
    public static void Main(string[] args) {
        Airline SAS = new(12, 2);
        Airline KLM = new(12, 2);
        Airline LOT = new(12, 2);
        Airline IAG = new(12, 2);

        Console.WriteLine($"{SAS.SorterAmount} {SAS.CheckInAmount}");
    }
}

internal class Sorter {
    internal Sorter(Airline airline) {
    }
}
internal class Baggage {
    internal Baggage() {

    }
}
