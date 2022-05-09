namespace BaggageSorting;

internal class CheckIn {
    internal static Queue<Baggage> BaggageList = new();
    private int _Id;

    internal CheckIn(int id, Airline airline) => _Id = id;

    internal static void CloseCheckIn() {

    }

    internal static void OpenCheckIn() {

    }
}
