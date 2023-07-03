void TwoAndOneDigitNumsDiff(int firstTens, int firstUnits, int secondUnits)
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
    
    System.Console.WriteLine($"Result tens: {firstTens}, result units: {firstUnits}");
}

TwoAndOneDigitNumsDiff(9, 6, 8);