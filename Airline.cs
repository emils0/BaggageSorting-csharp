namespace BaggageSorting;

internal class Airline {
    private int _sorterAmount;
    internal int SorterAmount => _sorterAmount;

    private int _checkInAmount;
    internal int CheckInAmount => _checkInAmount;

    internal Airline(int sorterAmount, int checkInAmount) {
        _sorterAmount = sorterAmount;
        _checkInAmount = checkInAmount;
    }
}
