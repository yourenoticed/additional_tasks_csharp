void ThreeAndTwoDigitNumsDiff(int firstHunds, int firstTens, int firstUnits, int secondTens, int secondUnits)
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
    if (firstTens - secondTens < 0)
    {
        firstHunds--;
        firstTens -= secondTens - 10;
    }
    else
    {
        firstTens -= secondTens;
    }
    System.Console.WriteLine($"Result hundreds: {firstHunds}, result tens: {firstTens}, result units: {firstUnits}");
}

ThreeAndTwoDigitNumsDiff(5, 4, 6, 8, 4);