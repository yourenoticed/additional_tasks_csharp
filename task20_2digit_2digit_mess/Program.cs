void TwoDigitNumsDiff(int firstTens, int firstUnits, int secondTens, int secondUnits)
{
    if (firstUnits - secondUnits < 0)
    {
        firstTens--;
        firstUnits = (firstUnits - secondUnits + 10);
    }
    else
    {
        firstUnits -= secondUnits;
    }
    firstTens -= secondTens;
    System.Console.WriteLine($"Result tens: {firstTens}, result units: {firstUnits}");
}

TwoDigitNumsDiff(9, 6, 8, 4);